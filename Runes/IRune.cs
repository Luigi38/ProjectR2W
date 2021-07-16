namespace ProjectR2W.Runes
{
    public interface IRune
    {
        /// <summary>
        /// 핵심 룬
        /// </summary>
        bool IsPrimary { get; set; }

        /// <summary>
        /// 보조 룬
        /// </summary>
        bool IsSecondary { get; set; }

        /// <summary>
        /// 핵심
        /// </summary>
        SlotRune Keystone { get; set; }

        /// <summary>
        /// 슬롯 1
        /// </summary>
        SlotRune Slot1 { get; set; }

        /// <summary>
        /// 슬롯 2
        /// </summary>
        SlotRune Slot2 { get; set; }

        /// <summary>
        /// 슬롯 3
        /// </summary>
        SlotRune Slot3 { get; set; }

        /// <summary>
        /// 공격 옵션
        /// </summary>
        SlotRune ShardSlot1 { get; set; }

        /// <summary>
        /// 유연 옵션
        /// </summary>
        SlotRune ShardSlot2 { get; set; }

        /// <summary>
        /// 방어 옵션
        /// </summary>
        SlotRune ShardSlot3 { get; set; }
    }
}