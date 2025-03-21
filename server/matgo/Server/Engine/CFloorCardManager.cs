﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Server.Engine
{
    public class CFloorCardManager
    {
        // 처음 바닥에 놓을 카드를 보관할 컨테이너.
        List<CCard> begin_cards;
        // 같은 번호의 카드를 하나로 묶어서 보관하는 컨테이너. 바닥 카드 정렬 이후에는 이 컨테이너를 사용한다.
        public List<CFloorSlot> slots { get; private set; }

        public CFloorCardManager()
        {
            // 바닥 초기화.
            this.slots = new List<CFloorSlot>();
            for (byte position = 0; position < 12; ++position)
            {
                this.slots.Add(new CFloorSlot(position));
            }

            this.begin_cards = new List<CCard>();
        }


        public void reset()
        {
            this.begin_cards.Clear();
            for (byte position = 0; position < 12; ++position)
            {
                this.slots[position].reset();
            }
        }
        public void put_to_begin_card(CCard card)
        {
            this.begin_cards.Add(card);
        }
        CFloorSlot find_empty_slot()
        {
            CFloorSlot slot = this.slots.Find(obj => obj.is_empty());
            return slot;
        }
        CFloorSlot find_slot(byte slot_number)
        {
            CFloorSlot slot = this.slots.Find(obj => obj.cards.Exists(c => c.slot_number == slot_number) == true);
            return slot;
        }
        CFloorSlot find_slot_by_number(byte number)
        {
            CFloorSlot slot = this.slots.Find(obj => obj.cards.Exists(c => c.number == number) == true);
            return slot;
        }
        public byte get_same_card_count_form_floor(byte card_number)
        {
            CFloorSlot slot = find_slot_by_number(card_number);
            if (slot == null)
            {
                return 0;
            }
            return (byte)slot.cards.Count;
        }
        // 해당번호와 동일한 위치에 카드를 놓는다.
        public void puton_card(CCard card)
        {
            CFloorSlot slot = find_slot(card.slot_number);
            if (slot == null)
            {
                slot = find_empty_slot();
                slot.add_card(card);
                return;
            }

            // 바닥에 깔려있으면 또 깔지 않음 (뒤집어서 보너스패 나왔을 경우, 패 2개 중 1개 선택 오류회피)
            if (!slot.is_same(card.number, card.position))
            {
                this.slots[slot.slot_position].add_card(card);
            }
        }
        public void puton_card(CCard bonus_card, byte slotnumber)
        {
            bonus_card.set_card_slot(slotnumber);
            CFloorSlot slot = find_slot(slotnumber);
            if (slot == null)
            {
                slot = find_empty_slot();
                slot.add_card(bonus_card);
                return;
            }

            this.slots[slot.slot_position].add_card(bonus_card);
        }
        public void remove_card(CCard card)
        {
            CFloorSlot slot = find_slot(card.slot_number);
            if (slot != null)
            {
                slot.remove_card(card);
                //UnityEngine.Debug.Log(string.Format("removed card. {0}, {1}, {2}, remain {3}",
                //	card.number, card.pae_type, card.position,
                //	slot.cards.Count));
            }
        }
        public byte get_same_number_card_count(byte number)
        {
            CFloorSlot slot = find_slot(number);
            if (slot == null)
            {
                return 0;
            }
            return (byte)slot.cards.Count;
        }
        public CCard get_first_card(byte number)
        {
            CFloorSlot slot = find_slot(number);
            if (slot == null)
            {
                return null;
            }
            return slot.cards[0];
        }
        public List<CCard> get_cards(byte number)
        {
            CFloorSlot slot = find_slot(number);
            if (slot == null)
            {
                return null;
            }
            return slot.cards;
        }
        public int get_cards_count(byte number)
        {
            CFloorSlot slot = find_slot_by_number(number);
            if (slot == null)
            {
                return 0;
            }
            return slot.cards.Count;
        }
        public List<CCard> has_begincards_bonuscards()
        {
            List<CCard> bonus_cards = new List<CCard>();
            for (int i = 0; i < this.begin_cards.Count; ++i)
            {
                if (this.begin_cards[i].is_bonus_card())
                {
                    bonus_cards.Add(this.begin_cards[i]);
                }
            }

            for (int i = 0; i < bonus_cards.Count; ++i)
            {
                this.begin_cards.Remove(bonus_cards[i]);
            }
            return bonus_cards;
        }

        public List<CCard> pop_bonus_cards()
        {
            List<CCard> bonus_cards = new List<CCard>();
            for (int i = 0; i < this.begin_cards.Count; ++i)
            {
                if (this.begin_cards[i].is_bonus_card())
                {
                    bonus_cards.Add(this.begin_cards[i]);
                }
            }

            //for (int i = 0; i < bonus_cards.Count; ++i)
            //{
            //    this.begin_cards.Remove(bonus_cards[i]);
            //}

            return bonus_cards;
        }

        /// <summary>
        /// 바닥에 깔린 카드중 동일한 카드들은 하나의 슬롯으로 쌓는다.
        /// </summary>
        public void refresh_floor_cards()
        {
            for (int i = 0; i < this.begin_cards.Count; ++i)
            {
                puton_card(this.begin_cards[i]);
            }
            this.begin_cards.Clear();
        }
        public bool validate_floor_card_counts()
        {
            int floor_card_count = 0;
            for (int i = 0; i < this.slots.Count; ++i)
            {
                floor_card_count += this.slots[i].cards.Count;
            }

            if (floor_card_count != 8)
            {
                return false;
            }

            return true;
        }
        public bool is_empty()
        {
            for (int i = 0; i < this.slots.Count; ++i)
            {
                if (!this.slots[i].is_empty())
                {
                    return false;
                }
            }

            return true;
        }
        public List<CCard> get_begin_cards()
        {
            return begin_cards;
        }
        public List<CCard> GetCardsList()
        {
            List<CCard> cards = new List<CCard>();

            if(begin_cards.Count != 0)
            {
                cards.AddRange(begin_cards);
            }
            else
            {
                for (int i = 0; i < this.slots.Count; ++i)
                {
                    cards.AddRange(slots[i].cards);
                }
            }
            return cards;
        }
    }
}
