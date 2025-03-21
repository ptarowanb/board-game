#ifndef __BINKPLUGINH__
#define __BINKPLUGINH__

#include "radtypes.h"

#define PLUG_IN_FUNC_DEC( ret ) RADEXPFUNC ret RADEXPLINK
#define PLUG_IN_FUNC_DEF( ret ) RADDEFFUNC ret RADLINK

enum BINKPLUGINAPI
{
  BinkGL = 0,
  BinkD3D9 = 1,
  BinkD3D11 = 2,
  BinkD3D12 = 3,
  BinkMetal = 4,
  BinkPS4 = 5,
  BinkXboxOneD3D11 = 6,
  BinkXboxOneD3D12 = 7,
};

typedef struct BINKPLUGIND3D12DEVICE // used for the device ptr in BinkPluginInit() on d3d312
{
  // elements should match the start of BINKCREATESHADERSD3D12 structure
  void *device; // ID3D12Device*
  void *queue; // ID3D12CommandQueue*
  U32 render_target_format; // DXGI_FORMAT 
} BINKPLUGIND3D12DEVICE;

// used for the device ptr in BinkPluginInit() on metal
typedef struct BINKPLUGINMETALDEVICE 
{
  void *device; // id< MTLDevice >
  void *queue; // id< MTLCommandQueue >
} BINKPLUGINMETALDEVICE;

typedef void * PS4Alloc(U32 Amt, U32 Alignment );
typedef void   PS4Free( void * ptr ); 
typedef struct BINKPLUGINPS4DEVICE // used for the device ptr in BinkPluginInit() on ps4
{
  PS4Alloc * GarlicAlloc;
  PS4Free * GarlicFree;
  PS4Alloc * OnionAlloc;
  PS4Free * OnionFree;
} BINKPLUGINPS4DEVICE;

// turn the plug in system on and off (these functions touch the graphics API)
PLUG_IN_FUNC_DEC( S32 ) BinkPluginInit( void * device, U32 graphics_api ); 
PLUG_IN_FUNC_DEC( void ) BinkPluginShutdown( void );                     

// spins through all binks, advancing frames and using gpu 
//   this function will hit the gpu on D3D9 and GPUAssisted (not plain GL and D3D11)
//   try to take less than ms_to_process (gotos will take longer, depending on goto time)
PLUG_IN_FUNC_DEC( void ) BinkPluginProcessBinks( S32 ms_to_process ); 

// spins through all binks, drawing everything, you can tell it what you want to draw
//   if you want to draw the rendertargets at a different moment within the frame
PLUG_IN_FUNC_DEC( void ) BinkPluginDraw( S32 draw_overlays, S32 draw_to_render_textures ); 

// turn on and off IO for all Binks - if the buffer runs *completely* out, we still hit the disc
PLUG_IN_FUNC_DEC( void ) BinkPluginIOPause( S32 IO_on );

// Tell Bink to try to use GPU-assisted mode (once on, always on)
PLUG_IN_FUNC_DEC( void ) BinkPluginTurnOnGPUAssist( void );

// used to specify the sounds to open at playback
enum BINKPLUGINSNDTRACK
{
  BinkSndNone               = 0, // don't open any sound tracks snd_track_start not used
  BinkSndSimple             = 1, // based on filename, OR simply mono or stereo sound in track snd_track_start (default speaker spread)
  BinkSndLanguageOverride   = 2, // mono or stereo sound in track 0, language track at snd_track_start
  BinkSnd51                 = 3, // 6 mono tracks in tracks snd_track_start[0..5]
  BinkSnd51LanguageOverride = 4, // 6 mono tracks in tracks 0..5, center language track at snd_track_start
  BinkSnd71                 = 5, // 8 mono tracks in tracks snd_track_start[0..7]
  BinkSnd71LanguageOverride = 6, // 8 mono tracks in tracks 0..7, center language track at snd_track_start
};

typedef struct BINKPLUGIN BINKPLUGIN;

// used to specify the how the video should be buffered
enum BINKPLUGINBUFFERING
{
  BinkStream                = 0, // stream the movie off the media during playback (caches about 1 second of video)
  BinkPreloadAll            = 1, // loads the whole movie into memory at Open time (will block)
  BinkStreamUntilResident   = 2, // streams the movie into a memory buffer as big as the movie, so it will be preloaded eventually)
};


// open and close a Bink file
PLUG_IN_FUNC_DEC( BINKPLUGIN * ) BinkPluginOpen( char const * name, U32 snd_track_type, S32 snd_track_start, U32 buffering_type, U64 file_byte_offset );
PLUG_IN_FUNC_DEC( void ) BinkPluginClose( BINKPLUGIN * bnk );

// set the path to load the library binaries from
PLUG_IN_FUNC_DEC( void ) BinkPluginSetPath( char const * path );


// error stuff
PLUG_IN_FUNC_DEC( char const * ) BinkPluginError( void );
PLUG_IN_FUNC_DEC( void ) BinkPluginSetError( char const * err );
PLUG_IN_FUNC_DEC( void ) BinkPluginAddError( char const * err );

typedef struct BINKPLUGININFO
{
  U64 BufferSize;
  U64 BufferUsed;
  U32 Width;
  U32 Height;
  U32 Frames;
  U32 FrameNum;
  U32 TotalFrames;
  U32 FrameRate;
  U32 FrameRateDiv;
  U32 LoopsRemaining;
  S32 ReadError;
  S32 TexturesError;
  U32 SndTrackType;          // BINKPLUGINSNDTRACK in use
  U32 NumTracksRequested;    // Num tracks
  U32 NumTracksOpened;
  U32 SoundDropOuts;
  U32 SkippedFrames;
  U32 PlaybackState;         // 0 = playing, 1 = paused, 2 = gotoing, 3 = at end
  F32 ProcessBinksFrameRate; // rate at which ProcessBinks is getting called (over last 32 processes)
  F32 Alpha;
} BINKPLUGININFO;

// get playback info
PLUG_IN_FUNC_DEC( void ) BinkPluginInfo( BINKPLUGIN * bnk, BINKPLUGININFO * info );

// call one of these functions every frame
PLUG_IN_FUNC_DEC( S32 ) BinkPluginScheduleToTexture( BINKPLUGIN * bnk, F32 x0, F32 y0, F32 x1, F32 y1, S32 depth, void * render_target_texture, U32 render_target_width, U32 render_target_height );
PLUG_IN_FUNC_DEC( S32 ) BinkPluginScheduleOverlay( BINKPLUGIN * bnk, F32 x0, F32 y0, F32 x1, F32 y1, S32 depth );
// call when everything is scheduled
PLUG_IN_FUNC_DEC( void ) BinkPluginAllScheduled( void );

// Pause playback
PLUG_IN_FUNC_DEC( void ) BinkPluginPause( BINKPLUGIN * bnk, S32 pause_frame ); // 0 = resume, or framenumber to pause on, or -1 to pause immediately

// start async jumping to frame (may draw same frame for long time until it finishes - can monitor with GetInfo)
//   goto_frame is dest frame (fast if key frame). Use 0 to cancel a previous goto at the current position
//   ms_per_process is how long Bink can spend decompressing in BinkPluginProcessBinks for this goto, use -1 for infinite wait
PLUG_IN_FUNC_DEC( void ) BinkPluginGoto( BINKPLUGIN * bnk, S32 goto_frame, S32 ms_per_process ); 

// set overall volume
PLUG_IN_FUNC_DEC( void ) BinkPluginVolume( BINKPLUGIN * bnk, F32 vol ); // 0 to 1.0

// set speaker volume
//   BinkSndSimple = count must be 2 (l/r)
//   BinkSndLanguageOverride = count must be 3 (l,r)/language
//   BinkSnd51 = count must be 6 (front l/r),center,sub,(rear l/r),
//   BinkSnd51LanguageOverride = 7 (front l/r),center,sub,(rear l/r),language
//   BinkSnd71 = count must be 8 (front l/r),center,sub,(read l/r),(surr l/r)
//   BinkSnd71LanguageOverride = 9 (front l/r),center,sub,(read l/r),(surr l/r), lang
PLUG_IN_FUNC_DEC( void ) BinkPluginSpeakerVolumes( BINKPLUGIN * bnk, F32 * vols, U32 count ); // 0 to 1.0 

// turn on/off video looping, loops == 0, infinite
PLUG_IN_FUNC_DEC( void ) BinkPluginLoop( BINKPLUGIN * bnk, U32 loops );

// sets HDR settings state used by BinkPluginScheduleToTexture and BinkPluginScheduleOverlay.
//   tonemap = 0 (disabled), 1 (enabled)
//   exposure is a scaling factor that happens before tonemapping (1.0=normal, <1.0 darken, >1.0 brighten)
//   output_luma = scales the tonemapped output to output this value as its maximum. 
//     For HDR displays, set this to the max luma of the display. Typically 1000 nits to 2000 nits.
PLUG_IN_FUNC_DEC( void ) BinkPluginSetHdrSettings( BINKPLUGIN * bnk, U32 tonemap, F32 exposure, S32 output_nits );

// sets Alpha settings state used by BinkPluginScheduleToTexture and BinkPluginScheduleOverlay.
//   alpha_value is just a constant blend value for entire video frame. 1 (default) opaque, 0 fully transparent.
PLUG_IN_FUNC_DEC( void ) BinkPluginSetAlphaSettings( BINKPLUGIN * bnk, F32 alpha_value );

// limit speakers to certain number of speakers
PLUG_IN_FUNC_DEC( void ) BinkPluginLimitSpeakers( U32 speaker_count );  // set to 1=mono max, 2=stereo max, 3=2.1 max, 4=4.0 max, 6=5.1 max, 8=7.1 max

// for windows only, use directsound (otherwise uses Xaudio2) call before first open
PLUG_IN_FUNC_DEC( void ) BinkPluginWindowsUseDirectSound( void );

// for D3D9 windows only (call before and after device reset to reset GPU video textures)
PLUG_IN_FUNC_DEC( void ) BinkPluginWindowsD3D9BeginReset( void );
PLUG_IN_FUNC_DEC( void ) BinkPluginWindowsD3D9EndReset( void );

#if defined(__RADWINRT__) || defined(__RADXBOXONE__)
  #define PLATFORM_HAS_D3D11 1
  #define PLATFORM_HAS_D3D12 1
#elif defined(__RADWIN__) 
  #define PLATFORM_HAS_D3D9 1
  #define PLATFORM_HAS_D3D11 1
  #define PLATFORM_HAS_D3D12 1
  #define PLATFORM_HAS_GL 1
#endif

#if defined(__RADLINUX__) || defined(__RADMAC__) || defined(__RADIPHONE__) || defined(__RADANDROID__)
  #define PLATFORM_HAS_GL 1
#endif

#if defined(__RADIPHONE__) || (defined(__RADMAC__) && defined(__RAD64__)) // metal on mac is 64-bit
  #define PLATFORM_HAS_METAL 1
#endif

#if defined(__RADWIN__) || defined(__RADLINUX__) || defined(__RADMAC__) || defined(__RADPS4__)
  #define PLATFORM_USES_DLLS
#endif

#if defined(PLATFORM_HAS_D3D12)

typedef struct BINKSCREENGPUDATA
{
  void * resource; // swap buffer ptr. On D3D12, must have the flags D3D12_RESOURCE_FLAG_ALLOW_RENDER_TARGET
  U32 width, height;
  U32 resource_state; // D3D12_RESOURCE_STATES
} BINKSCREENGPUDATA;

#endif

#if defined(PLATFORM_HAS_METAL)

typedef struct BINKSCREENGPUDATA
{
  void * cmdBuf; // id< MTLCommandBuffer >
  void * resource; // id<MTLTexture> 
  U32 width, height;
} BINKSCREENGPUDATA;

#endif

#if defined(PLATFORM_HAS_D3D12) || defined(PLATFORM_HAS_METAL)

// specifies per-frame data needed to render the current frame - call before BinkPluginDraw
//   Only used on d3d12, Metal and PS4
//   D3D12 and Metal - pass a BINKSCREENGPUDATA *
//   PS4 - pass a Gnmx::LightweightGfxContext * 
PLUG_IN_FUNC_DEC( void ) BinkPluginSetPerFrameInfo( void * info );  

#endif


// dynamic linking typedefs - you can use DO_BINKPLUGIN_PROCS() to create them and such
#define DO_BINKPLUGIN_PROCS() \
  ProcessProc(  8, S32,            BinkPluginInit,              void *device, U32 graphics_api ) \
  ProcessProc(  0, void,           BinkPluginShutdown,          void ) \
  ProcessProc( 24, BINKPLUGIN *,   BinkPluginOpen,              char const * name, U32 snd_track_type, S32 snd_track_start, U32 buffering_type, U64 file_byte_offset ) \
  ProcessProc(  4, void,           BinkPluginClose,             BINKPLUGIN *bnk ) \
  ProcessProc(  8, void,           BinkPluginInfo,              BINKPLUGIN * bnk, BINKPLUGININFO *info ) \
  ProcessProc( 12, void,           BinkPluginGoto,              BINKPLUGIN * bnk, S32 goto_frame, S32 ms_per_process ) \
  ProcessProc(  4, void,           BinkPluginProcessBinks,      S32 ms_to_process ) \
  ProcessProc(  8, void,           BinkPluginLoop,              BINKPLUGIN *bnk, U32 loops ) \
  ProcessProc(  8, void,           BinkPluginPause,             BINKPLUGIN *bnk, S32 pause_frame ) \
  ProcessProc(  8, void,           BinkPluginDraw,              S32 draw_overlays, S32 draw_to_render_textures ) \
  ProcessProc(  4, void,           BinkPluginSetPerFrameInfo,   void * info ) \
  ProcessProc( 36, S32,            BinkPluginScheduleToTexture, BINKPLUGIN *bnk, F32 x0, F32 y0, F32 x1, F32 y1, S32 depth, void * render_target_texture, U32 render_target_width, U32 render_target_height ) \
  ProcessProc( 24, S32,            BinkPluginScheduleOverlay,   BINKPLUGIN *bnk, F32 x0, F32 y0, F32 x1, F32 y1, S32 depth ) \
  ProcessProc(  0, void,           BinkPluginAllScheduled,      void ) \
  ProcessProc(  4, void,           BinkPluginIOPause,           S32 IO_on ) \
  ProcessProc(  0, void,           BinkPluginTurnOnGPUAssist,   void ) \
  ProcessProc(  0, char const *,   BinkPluginError,             void ) \
  ProcessProc(  8, void,           BinkPluginVolume,            BINKPLUGIN * bnk, F32 vol ) \
  ProcessProc( 12, void,           BinkPluginSpeakerVolumes,    BINKPLUGIN * bnk, F32 * vols, U32 count ) \
  ProcessProc( 16, void,           BinkPluginSetHdrSettings,    BINKPLUGIN * bnk, U32 tonemap, F32 exposure, S32 output_nits ) \
  ProcessProc(  8, void,           BinkPluginSetAlphaSettings,  BINKPLUGIN * bnk, F32 alpha_value ) \
  ProcessProc(  4, void,           BinkPluginSetPath,           char const * path ) \


#define ProcessProc( bytes, ret, name, ...) typedef ret RADLINK RR_STRING_JOIN( name, Proc )(__VA_ARGS__); extern RR_STRING_JOIN( name, Proc ) * RR_STRING_JOIN( p, name );
  DO_BINKPLUGIN_PROCS()
#undef ProcessProc

#endif
