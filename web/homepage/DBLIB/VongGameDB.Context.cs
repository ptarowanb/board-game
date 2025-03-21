﻿//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 템플릿에서 생성되었습니다.
//
//     이 파일을 수동으로 변경하면 응용 프로그램에서 예기치 않은 동작이 발생할 수 있습니다.
//     이 파일을 수동으로 변경하면 코드가 다시 생성될 때 변경 내용을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBLIB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class GameEntities : DbContext
    {
        public GameEntities()
            : base("name=GameEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdminUser> AdminUser { get; set; }
        public virtual DbSet<GameBadugiMadeLimit> GameBadugiMadeLimit { get; set; }
        public virtual DbSet<GameBadugiPush> GameBadugiPush { get; set; }
        public virtual DbSet<GameGiveMoney> GameGiveMoney { get; set; }
        public virtual DbSet<MemberGamePoint> MemberGamePoint { get; set; }
        public virtual DbSet<MemberGameRestrict> MemberGameRestrict { get; set; }
        public virtual DbSet<PlayerBadugiMission> PlayerBadugiMission { get; set; }
        public virtual DbSet<PlayerGameMoney> PlayerGameMoney { get; set; }
        public virtual DbSet<PlayerItemList> PlayerItemList { get; set; }
        public virtual DbSet<ReportBadugiResult> ReportBadugiResult { get; set; }
        public virtual DbSet<WebNoticeList> WebNoticeList { get; set; }
        public virtual DbSet<AdminCode> AdminCode { get; set; }
        public virtual DbSet<AdminLog> AdminLog { get; set; }
        public virtual DbSet<LogUserLogin> LogUserLogin { get; set; }
        public virtual DbSet<PurchaseAndroid> PurchaseAndroid { get; set; }
        public virtual DbSet<ReportCurrentUsers> ReportCurrentUsers { get; set; }
        public virtual DbSet<RankBadugiFreeMoney> RankBadugiFreeMoney { get; set; }
        public virtual DbSet<RankMatgoFreeMoney> RankMatgoFreeMoney { get; set; }
        public virtual DbSet<ProductList> ProductList { get; set; }
        public virtual DbSet<V_WEB_PlayerInfo> V_WEB_PlayerInfo { get; set; }
        public virtual DbSet<V_WEB_RankingMatgoBetting> V_WEB_RankingMatgoBetting { get; set; }
        public virtual DbSet<V_WEB_ShopItem> V_WEB_ShopItem { get; set; }
        public virtual DbSet<PlayerAdminMemo> PlayerAdminMemo { get; set; }
        public virtual DbSet<V_WEB_RankingBadugiBetting> V_WEB_RankingBadugiBetting { get; set; }
        public virtual DbSet<PurchaseList> PurchaseList { get; set; }
        public virtual DbSet<LogExchangeMileage> LogExchangeMileage { get; set; }
        public virtual DbSet<LogPlayerNicknameChange> LogPlayerNicknameChange { get; set; }
        public virtual DbSet<V_WEB_PlayerItemList> V_WEB_PlayerItemList { get; set; }
        public virtual DbSet<V_MobileShop> V_MobileShop { get; set; }
        public virtual DbSet<V_PlayerItemList> V_PlayerItemList { get; set; }
        public virtual DbSet<EventLottoEnter> EventLottoEnter { get; set; }
        public virtual DbSet<qna> qna { get; set; }
        public virtual DbSet<qna_articletype> qna_articletype { get; set; }
        public virtual DbSet<EventLotto> EventLotto { get; set; }
        public virtual DbSet<EventLottoResult> EventLottoResult { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<EventLottoBase> EventLottoBase { get; set; }
        public virtual DbSet<AdminBlockIP> AdminBlockIP { get; set; }
        public virtual DbSet<AdminBlockUser> AdminBlockUser { get; set; }
        public virtual DbSet<GameBadugiPushBase> GameBadugiPushBase { get; set; }
        public virtual DbSet<GameBadugiPushGame> GameBadugiPushGame { get; set; }
        public virtual DbSet<GameBadugiPushUser> GameBadugiPushUser { get; set; }
        public virtual DbSet<GameCurrentUser> GameCurrentUser { get; set; }
        public virtual DbSet<GameDealFee> GameDealFee { get; set; }
        public virtual DbSet<GameJackPotMoney> GameJackPotMoney { get; set; }
        public virtual DbSet<GameJackPotSet> GameJackPotSet { get; set; }
        public virtual DbSet<GameMoneyFlow> GameMoneyFlow { get; set; }
        public virtual DbSet<GameRoomList> GameRoomList { get; set; }
        public virtual DbSet<GameServerMessage> GameServerMessage { get; set; }
        public virtual DbSet<LogGameBadugi> LogGameBadugi { get; set; }
        public virtual DbSet<LogGameMatgo> LogGameMatgo { get; set; }
        public virtual DbSet<LogGamePlayer> LogGamePlayer { get; set; }
        public virtual DbSet<LogPurchase> LogPurchase { get; set; }
        public virtual DbSet<PaymentType> PaymentType { get; set; }
        public virtual DbSet<PlayerBadugi> PlayerBadugi { get; set; }
        public virtual DbSet<PlayerMatgo> PlayerMatgo { get; set; }
        public virtual DbSet<PlayerMatgoMission> PlayerMatgoMission { get; set; }
        public virtual DbSet<PlayerPassword> PlayerPassword { get; set; }
        public virtual DbSet<PlayerPayment> PlayerPayment { get; set; }
        public virtual DbSet<PlayerSafeBox> PlayerSafeBox { get; set; }
        public virtual DbSet<C_error> C_error { get; set; }
        public virtual DbSet<GameDefaultMileage> GameDefaultMileage { get; set; }
        public virtual DbSet<LogGiftMemberPoint> LogGiftMemberPoint { get; set; }
        public virtual DbSet<LogJackPot> LogJackPot { get; set; }
        public virtual DbSet<LogMemberPoint> LogMemberPoint { get; set; }
        public virtual DbSet<LogRechargeMoney> LogRechargeMoney { get; set; }
        public virtual DbSet<ReportGameMoney> ReportGameMoney { get; set; }
        public virtual DbSet<V_AdminList> V_AdminList { get; set; }
        public virtual DbSet<V_AdminLog> V_AdminLog { get; set; }
        public virtual DbSet<V_BlockUser> V_BlockUser { get; set; }
        public virtual DbSet<V_CurrentRoom> V_CurrentRoom { get; set; }
        public virtual DbSet<V_CurrentUser> V_CurrentUser { get; set; }
        public virtual DbSet<V_LogEventLotto> V_LogEventLotto { get; set; }
        public virtual DbSet<V_LogGameResult> V_LogGameResult { get; set; }
        public virtual DbSet<V_LogJackPotReward> V_LogJackPotReward { get; set; }
        public virtual DbSet<V_LogMileage> V_LogMileage { get; set; }
        public virtual DbSet<V_LogMileageMove> V_LogMileageMove { get; set; }
        public virtual DbSet<V_LogRechargeMoney> V_LogRechargeMoney { get; set; }
        public virtual DbSet<V_LogUserLogin> V_LogUserLogin { get; set; }
        public virtual DbSet<V_Player> V_Player { get; set; }
        public virtual DbSet<V_PurchaseAndroidMonth> V_PurchaseAndroidMonth { get; set; }
        public virtual DbSet<V_UserList> V_UserList { get; set; }
        public virtual DbSet<Coupon> Coupon { get; set; }
        public virtual DbSet<V_LogPurchase> V_LogPurchase { get; set; }
        public virtual DbSet<V_LogCoupon> V_LogCoupon { get; set; }
        public virtual DbSet<LogMemberDailyPoint> LogMemberDailyPoint { get; set; }
        public virtual DbSet<LogMemberDailyPoint2> LogMemberDailyPoint2 { get; set; }
        public virtual DbSet<V_MemberFriendList> V_MemberFriendList { get; set; }
        public virtual DbSet<V_MemberUserList> V_MemberUserList { get; set; }
        public virtual DbSet<GameCurrentDummy> GameCurrentDummy { get; set; }
        public virtual DbSet<GameMatgoPush> GameMatgoPush { get; set; }
        public virtual DbSet<GameMatgoPushBase> GameMatgoPushBase { get; set; }
        public virtual DbSet<GameMatgoPushGame> GameMatgoPushGame { get; set; }
        public virtual DbSet<GameMatgoPushUser> GameMatgoPushUser { get; set; }
        public virtual DbSet<V_CurrentUserMoney> V_CurrentUserMoney { get; set; }
        public virtual DbSet<V_GameResultBadugiUser> V_GameResultBadugiUser { get; set; }
        public virtual DbSet<V_GameResultMatgoUser> V_GameResultMatgoUser { get; set; }
        public virtual DbSet<V_PlayerGameInfo> V_PlayerGameInfo { get; set; }
        public virtual DbSet<V_PlayerGameItem> V_PlayerGameItem { get; set; }
        public virtual DbSet<V_PlayerInfo> V_PlayerInfo { get; set; }
        public virtual DbSet<V_FriendList> V_FriendList { get; set; }
        public virtual DbSet<FriendDaySnapshot> FriendDaySnapshot { get; set; }
        public virtual DbSet<LogDetail> LogDetail { get; set; }
        public virtual DbSet<V_LogDetail> V_LogDetail { get; set; }
        public virtual DbSet<EventJackpotHunter> EventJackpotHunter { get; set; }
    
        public virtual ObjectResult<SP_PlayerGameData_Result> SP_PlayerGameData(Nullable<int> playerId, ObjectParameter out_Result)
        {
            var playerIdParameter = playerId.HasValue ?
                new ObjectParameter("PlayerId", playerId) :
                new ObjectParameter("PlayerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_PlayerGameData_Result>("SP_PlayerGameData", playerIdParameter, out_Result);
        }
    
        public virtual int SP_BuyAvatar(string userId, string payType, Nullable<int> avatarId, ObjectParameter buyResult, ObjectParameter resultMessage, ObjectParameter viewLabel)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var payTypeParameter = payType != null ?
                new ObjectParameter("PayType", payType) :
                new ObjectParameter("PayType", typeof(string));
    
            var avatarIdParameter = avatarId.HasValue ?
                new ObjectParameter("AvatarId", avatarId) :
                new ObjectParameter("AvatarId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_BuyAvatar", userIdParameter, payTypeParameter, avatarIdParameter, buyResult, resultMessage, viewLabel);
        }
    
        public virtual int SP_PlayerMileageExchange(Nullable<int> playerId, Nullable<long> mileage, ObjectParameter out_Result)
        {
            var playerIdParameter = playerId.HasValue ?
                new ObjectParameter("PlayerId", playerId) :
                new ObjectParameter("PlayerId", typeof(int));
    
            var mileageParameter = mileage.HasValue ?
                new ObjectParameter("Mileage", mileage) :
                new ObjectParameter("Mileage", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_PlayerMileageExchange", playerIdParameter, mileageParameter, out_Result);
        }
    
        public virtual ObjectResult<SP_PlayerMyRoomAction_Result> SP_PlayerMyRoomAction(Nullable<int> playerId, Nullable<int> itemId, string action, ObjectParameter out_Result)
        {
            var playerIdParameter = playerId.HasValue ?
                new ObjectParameter("PlayerId", playerId) :
                new ObjectParameter("PlayerId", typeof(int));
    
            var itemIdParameter = itemId.HasValue ?
                new ObjectParameter("ItemId", itemId) :
                new ObjectParameter("ItemId", typeof(int));
    
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_PlayerMyRoomAction_Result>("SP_PlayerMyRoomAction", playerIdParameter, itemIdParameter, actionParameter, out_Result);
        }
    
        public virtual ObjectResult<SP_PlayerEventLottoEnter_Result> SP_PlayerEventLottoEnter(Nullable<int> playerId, Nullable<int> number1, Nullable<int> number2, Nullable<int> number3, Nullable<int> number4, Nullable<int> number5, Nullable<int> number6, ObjectParameter out_Result)
        {
            var playerIdParameter = playerId.HasValue ?
                new ObjectParameter("PlayerId", playerId) :
                new ObjectParameter("PlayerId", typeof(int));
    
            var number1Parameter = number1.HasValue ?
                new ObjectParameter("Number1", number1) :
                new ObjectParameter("Number1", typeof(int));
    
            var number2Parameter = number2.HasValue ?
                new ObjectParameter("Number2", number2) :
                new ObjectParameter("Number2", typeof(int));
    
            var number3Parameter = number3.HasValue ?
                new ObjectParameter("Number3", number3) :
                new ObjectParameter("Number3", typeof(int));
    
            var number4Parameter = number4.HasValue ?
                new ObjectParameter("Number4", number4) :
                new ObjectParameter("Number4", typeof(int));
    
            var number5Parameter = number5.HasValue ?
                new ObjectParameter("Number5", number5) :
                new ObjectParameter("Number5", typeof(int));
    
            var number6Parameter = number6.HasValue ?
                new ObjectParameter("Number6", number6) :
                new ObjectParameter("Number6", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_PlayerEventLottoEnter_Result>("SP_PlayerEventLottoEnter", playerIdParameter, number1Parameter, number2Parameter, number3Parameter, number4Parameter, number5Parameter, number6Parameter, out_Result);
        }
    
        public virtual int SP_EventLottoDraw(Nullable<int> number1, Nullable<int> number2, Nullable<int> number3, Nullable<int> number4, Nullable<int> number5, Nullable<int> number6, Nullable<int> number7, ObjectParameter out_Result)
        {
            var number1Parameter = number1.HasValue ?
                new ObjectParameter("Number1", number1) :
                new ObjectParameter("Number1", typeof(int));
    
            var number2Parameter = number2.HasValue ?
                new ObjectParameter("Number2", number2) :
                new ObjectParameter("Number2", typeof(int));
    
            var number3Parameter = number3.HasValue ?
                new ObjectParameter("Number3", number3) :
                new ObjectParameter("Number3", typeof(int));
    
            var number4Parameter = number4.HasValue ?
                new ObjectParameter("Number4", number4) :
                new ObjectParameter("Number4", typeof(int));
    
            var number5Parameter = number5.HasValue ?
                new ObjectParameter("Number5", number5) :
                new ObjectParameter("Number5", typeof(int));
    
            var number6Parameter = number6.HasValue ?
                new ObjectParameter("Number6", number6) :
                new ObjectParameter("Number6", typeof(int));
    
            var number7Parameter = number7.HasValue ?
                new ObjectParameter("Number7", number7) :
                new ObjectParameter("Number7", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_EventLottoDraw", number1Parameter, number2Parameter, number3Parameter, number4Parameter, number5Parameter, number6Parameter, number7Parameter, out_Result);
        }
    
        public virtual int 적립금처리()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("적립금처리");
        }
    
        public virtual int 통계_게임머니()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("통계_게임머니");
        }
    
        public virtual int 통계_맞고수익랭킹()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("통계_맞고수익랭킹");
        }
    
        public virtual int 통계_바둑이수익랭킹()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("통계_바둑이수익랭킹");
        }
    
        public virtual int 통계_바둑이족보()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("통계_바둑이족보");
        }
    
        public virtual int 통계_접속자()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("통계_접속자");
        }
    
        public virtual int error(string type, string message)
        {
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            var messageParameter = message != null ?
                new ObjectParameter("Message", message) :
                new ObjectParameter("Message", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("error", typeParameter, messageParameter);
        }
    
        public virtual ObjectResult<SP_ADMIN_PlayerSignUp_Result> SP_ADMIN_PlayerSignUp(string userId, string nickName, string userName, string phone, string pw, string refUser, Nullable<float> dealBadugi, Nullable<float> dealMatgo, Nullable<float> dealHoldem, string memo, string ip, ObjectParameter out_Result)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var nickNameParameter = nickName != null ?
                new ObjectParameter("NickName", nickName) :
                new ObjectParameter("NickName", typeof(string));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var pwParameter = pw != null ?
                new ObjectParameter("Pw", pw) :
                new ObjectParameter("Pw", typeof(string));
    
            var refUserParameter = refUser != null ?
                new ObjectParameter("RefUser", refUser) :
                new ObjectParameter("RefUser", typeof(string));
    
            var dealBadugiParameter = dealBadugi.HasValue ?
                new ObjectParameter("DealBadugi", dealBadugi) :
                new ObjectParameter("DealBadugi", typeof(float));
    
            var dealMatgoParameter = dealMatgo.HasValue ?
                new ObjectParameter("DealMatgo", dealMatgo) :
                new ObjectParameter("DealMatgo", typeof(float));
    
            var dealHoldemParameter = dealHoldem.HasValue ?
                new ObjectParameter("DealHoldem", dealHoldem) :
                new ObjectParameter("DealHoldem", typeof(float));
    
            var memoParameter = memo != null ?
                new ObjectParameter("Memo", memo) :
                new ObjectParameter("Memo", typeof(string));
    
            var ipParameter = ip != null ?
                new ObjectParameter("Ip", ip) :
                new ObjectParameter("Ip", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ADMIN_PlayerSignUp_Result>("SP_ADMIN_PlayerSignUp", userIdParameter, nickNameParameter, userNameParameter, phoneParameter, pwParameter, refUserParameter, dealBadugiParameter, dealMatgoParameter, dealHoldemParameter, memoParameter, ipParameter, out_Result);
        }
    
        public virtual ObjectResult<Nullable<int>> SP_PlayerShopItemBuy(Nullable<int> playerId, Nullable<int> shopItemId, ObjectParameter out_Result)
        {
            var playerIdParameter = playerId.HasValue ?
                new ObjectParameter("PlayerId", playerId) :
                new ObjectParameter("PlayerId", typeof(int));
    
            var shopItemIdParameter = shopItemId.HasValue ?
                new ObjectParameter("ShopItemId", shopItemId) :
                new ObjectParameter("ShopItemId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_PlayerShopItemBuy", playerIdParameter, shopItemIdParameter, out_Result);
        }
    
        public virtual int SP_PlayerUseCoupon(Nullable<int> playerId, string coupon, ObjectParameter out_Result)
        {
            var playerIdParameter = playerId.HasValue ?
                new ObjectParameter("PlayerId", playerId) :
                new ObjectParameter("PlayerId", typeof(int));
    
            var couponParameter = coupon != null ?
                new ObjectParameter("Coupon", coupon) :
                new ObjectParameter("Coupon", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_PlayerUseCoupon", playerIdParameter, couponParameter, out_Result);
        }
    
        public virtual ObjectResult<SP_PlayerRegisterCode_Result> SP_PlayerRegisterCode(Nullable<int> playerId, string recomCode, ObjectParameter out_Result)
        {
            var playerIdParameter = playerId.HasValue ?
                new ObjectParameter("PlayerId", playerId) :
                new ObjectParameter("PlayerId", typeof(int));
    
            var recomCodeParameter = recomCode != null ?
                new ObjectParameter("RecomCode", recomCode) :
                new ObjectParameter("RecomCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_PlayerRegisterCode_Result>("SP_PlayerRegisterCode", playerIdParameter, recomCodeParameter, out_Result);
        }
    
        public virtual int 친구목록정산()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("친구목록정산");
        }
    
        public virtual ObjectResult<AccountTemp_Result> AccountTemp(string num)
        {
            var numParameter = num != null ?
                new ObjectParameter("num", num) :
                new ObjectParameter("num", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AccountTemp_Result>("AccountTemp", numParameter);
        }
    
        public virtual int Room_BadugiResultGame(Nullable<int> channelId, Nullable<long> playedGameMoney, Nullable<long> dealerFeeMoney, Nullable<long> jackPotFeeMoney, Nullable<int> moneyType, Nullable<long> eventMoney1, Nullable<long> eventMoney2, Nullable<long> bbingCutMoney)
        {
            var channelIdParameter = channelId.HasValue ?
                new ObjectParameter("ChannelId", channelId) :
                new ObjectParameter("ChannelId", typeof(int));
    
            var playedGameMoneyParameter = playedGameMoney.HasValue ?
                new ObjectParameter("PlayedGameMoney", playedGameMoney) :
                new ObjectParameter("PlayedGameMoney", typeof(long));
    
            var dealerFeeMoneyParameter = dealerFeeMoney.HasValue ?
                new ObjectParameter("DealerFeeMoney", dealerFeeMoney) :
                new ObjectParameter("DealerFeeMoney", typeof(long));
    
            var jackPotFeeMoneyParameter = jackPotFeeMoney.HasValue ?
                new ObjectParameter("JackPotFeeMoney", jackPotFeeMoney) :
                new ObjectParameter("JackPotFeeMoney", typeof(long));
    
            var moneyTypeParameter = moneyType.HasValue ?
                new ObjectParameter("MoneyType", moneyType) :
                new ObjectParameter("MoneyType", typeof(int));
    
            var eventMoney1Parameter = eventMoney1.HasValue ?
                new ObjectParameter("EventMoney1", eventMoney1) :
                new ObjectParameter("EventMoney1", typeof(long));
    
            var eventMoney2Parameter = eventMoney2.HasValue ?
                new ObjectParameter("EventMoney2", eventMoney2) :
                new ObjectParameter("EventMoney2", typeof(long));
    
            var bbingCutMoneyParameter = bbingCutMoney.HasValue ?
                new ObjectParameter("BbingCutMoney", bbingCutMoney) :
                new ObjectParameter("BbingCutMoney", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Room_BadugiResultGame", channelIdParameter, playedGameMoneyParameter, dealerFeeMoneyParameter, jackPotFeeMoneyParameter, moneyTypeParameter, eventMoney1Parameter, eventMoney2Parameter, bbingCutMoneyParameter);
        }
    
        public virtual ObjectResult<Room_BadugiResultPlayer_Result> Room_BadugiResultPlayer(Nullable<int> playerID, Nullable<long> moneyChange, Nullable<long> moneyBet, Nullable<long> moneyDeal, Nullable<int> matchResult, Nullable<int> moneyType, Nullable<float> roomDealFee, Nullable<int> channelId, Nullable<bool> dummy)
        {
            var playerIDParameter = playerID.HasValue ?
                new ObjectParameter("PlayerID", playerID) :
                new ObjectParameter("PlayerID", typeof(int));
    
            var moneyChangeParameter = moneyChange.HasValue ?
                new ObjectParameter("MoneyChange", moneyChange) :
                new ObjectParameter("MoneyChange", typeof(long));
    
            var moneyBetParameter = moneyBet.HasValue ?
                new ObjectParameter("MoneyBet", moneyBet) :
                new ObjectParameter("MoneyBet", typeof(long));
    
            var moneyDealParameter = moneyDeal.HasValue ?
                new ObjectParameter("MoneyDeal", moneyDeal) :
                new ObjectParameter("MoneyDeal", typeof(long));
    
            var matchResultParameter = matchResult.HasValue ?
                new ObjectParameter("MatchResult", matchResult) :
                new ObjectParameter("MatchResult", typeof(int));
    
            var moneyTypeParameter = moneyType.HasValue ?
                new ObjectParameter("MoneyType", moneyType) :
                new ObjectParameter("MoneyType", typeof(int));
    
            var roomDealFeeParameter = roomDealFee.HasValue ?
                new ObjectParameter("RoomDealFee", roomDealFee) :
                new ObjectParameter("RoomDealFee", typeof(float));
    
            var channelIdParameter = channelId.HasValue ?
                new ObjectParameter("ChannelId", channelId) :
                new ObjectParameter("ChannelId", typeof(int));
    
            var dummyParameter = dummy.HasValue ?
                new ObjectParameter("Dummy", dummy) :
                new ObjectParameter("Dummy", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Room_BadugiResultPlayer_Result>("Room_BadugiResultPlayer", playerIDParameter, moneyChangeParameter, moneyBetParameter, moneyDealParameter, matchResultParameter, moneyTypeParameter, roomDealFeeParameter, channelIdParameter, dummyParameter);
        }
    
        public virtual int Room_MatgoResultGame(Nullable<int> channelId, Nullable<long> playedGameMoney, Nullable<long> dealerFeeMoney, Nullable<long> jackPotFeeMoney, Nullable<int> moneyType, Nullable<long> eventMoney)
        {
            var channelIdParameter = channelId.HasValue ?
                new ObjectParameter("ChannelId", channelId) :
                new ObjectParameter("ChannelId", typeof(int));
    
            var playedGameMoneyParameter = playedGameMoney.HasValue ?
                new ObjectParameter("PlayedGameMoney", playedGameMoney) :
                new ObjectParameter("PlayedGameMoney", typeof(long));
    
            var dealerFeeMoneyParameter = dealerFeeMoney.HasValue ?
                new ObjectParameter("DealerFeeMoney", dealerFeeMoney) :
                new ObjectParameter("DealerFeeMoney", typeof(long));
    
            var jackPotFeeMoneyParameter = jackPotFeeMoney.HasValue ?
                new ObjectParameter("JackPotFeeMoney", jackPotFeeMoney) :
                new ObjectParameter("JackPotFeeMoney", typeof(long));
    
            var moneyTypeParameter = moneyType.HasValue ?
                new ObjectParameter("MoneyType", moneyType) :
                new ObjectParameter("MoneyType", typeof(int));
    
            var eventMoneyParameter = eventMoney.HasValue ?
                new ObjectParameter("EventMoney", eventMoney) :
                new ObjectParameter("EventMoney", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Room_MatgoResultGame", channelIdParameter, playedGameMoneyParameter, dealerFeeMoneyParameter, jackPotFeeMoneyParameter, moneyTypeParameter, eventMoneyParameter);
        }
    
        public virtual ObjectResult<Room_MatgoResultPlayer_Result> Room_MatgoResultPlayer(Nullable<int> playerID, Nullable<long> moneyChange, Nullable<long> moneyBet, Nullable<long> moneyDeal, Nullable<int> matchResult, Nullable<int> moneyType, Nullable<float> roomDealFee, Nullable<int> channelId, Nullable<bool> dummy)
        {
            var playerIDParameter = playerID.HasValue ?
                new ObjectParameter("PlayerID", playerID) :
                new ObjectParameter("PlayerID", typeof(int));
    
            var moneyChangeParameter = moneyChange.HasValue ?
                new ObjectParameter("MoneyChange", moneyChange) :
                new ObjectParameter("MoneyChange", typeof(long));
    
            var moneyBetParameter = moneyBet.HasValue ?
                new ObjectParameter("MoneyBet", moneyBet) :
                new ObjectParameter("MoneyBet", typeof(long));
    
            var moneyDealParameter = moneyDeal.HasValue ?
                new ObjectParameter("MoneyDeal", moneyDeal) :
                new ObjectParameter("MoneyDeal", typeof(long));
    
            var matchResultParameter = matchResult.HasValue ?
                new ObjectParameter("MatchResult", matchResult) :
                new ObjectParameter("MatchResult", typeof(int));
    
            var moneyTypeParameter = moneyType.HasValue ?
                new ObjectParameter("MoneyType", moneyType) :
                new ObjectParameter("MoneyType", typeof(int));
    
            var roomDealFeeParameter = roomDealFee.HasValue ?
                new ObjectParameter("RoomDealFee", roomDealFee) :
                new ObjectParameter("RoomDealFee", typeof(float));
    
            var channelIdParameter = channelId.HasValue ?
                new ObjectParameter("ChannelId", channelId) :
                new ObjectParameter("ChannelId", typeof(int));
    
            var dummyParameter = dummy.HasValue ?
                new ObjectParameter("Dummy", dummy) :
                new ObjectParameter("Dummy", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Room_MatgoResultPlayer_Result>("Room_MatgoResultPlayer", playerIDParameter, moneyChangeParameter, moneyBetParameter, moneyDealParameter, matchResultParameter, moneyTypeParameter, roomDealFeeParameter, channelIdParameter, dummyParameter);
        }
    
        public virtual int SP_WebJoinProc(string userId, string userName, string nickName, string phoneNumber, string password, string refUser, string iP, string from, string cert_no, string ci, string di, ObjectParameter out_Result)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var nickNameParameter = nickName != null ?
                new ObjectParameter("NickName", nickName) :
                new ObjectParameter("NickName", typeof(string));
    
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var refUserParameter = refUser != null ?
                new ObjectParameter("RefUser", refUser) :
                new ObjectParameter("RefUser", typeof(string));
    
            var iPParameter = iP != null ?
                new ObjectParameter("IP", iP) :
                new ObjectParameter("IP", typeof(string));
    
            var fromParameter = from != null ?
                new ObjectParameter("From", from) :
                new ObjectParameter("From", typeof(string));
    
            var cert_noParameter = cert_no != null ?
                new ObjectParameter("cert_no", cert_no) :
                new ObjectParameter("cert_no", typeof(string));
    
            var ciParameter = ci != null ?
                new ObjectParameter("ci", ci) :
                new ObjectParameter("ci", typeof(string));
    
            var diParameter = di != null ?
                new ObjectParameter("di", di) :
                new ObjectParameter("di", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_WebJoinProc", userIdParameter, userNameParameter, nickNameParameter, phoneNumberParameter, passwordParameter, refUserParameter, iPParameter, fromParameter, cert_noParameter, ciParameter, diParameter, out_Result);
        }
    }
}
