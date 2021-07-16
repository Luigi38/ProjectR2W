using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectR2W.Runes
{
    /// <summary>
    /// 룬 - 영감
    /// </summary>
    public class InspirationRune : IRune
    {
        public bool IsPrimary { get; set; }
        public bool IsSecondary { get; set; }

        public SlotRune Keystone { get; set; }

        public SlotRune Slot1 { get; set; }
        public SlotRune Slot2 { get; set; }
        public SlotRune Slot3 { get; set; }

        public SlotRune ShardSlot1 { get; set; }
        public SlotRune ShardSlot2 { get; set; }
        public SlotRune ShardSlot3 { get; set; }

        public InspirationRune()
        {
            //
            Keystone = new SlotRune(4);

            //
            Slot1 = new SlotRune(3);

            //
            Slot2 = new SlotRune(3);

            //
            Slot3 = new SlotRune(3);

            ShardSlot1 = new SlotRune(3); //적응형 능력치, 공격 속도, 스킬 가속
            ShardSlot2 = new SlotRune(3); //적응형 능력치, 방어력, 마법 저항력
            ShardSlot3 = new SlotRune(3); //체력, 방어력, 마법 저항력
        }
    }
}
