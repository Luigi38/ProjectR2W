using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectR2W.Runes
{
    /// <summary>
    /// 룬 - 지배
    /// </summary>
    public class DominationRune : IRune
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

        public DominationRune()
        {
            //감전, 포식자, 어둠의 수확, 칼날비
            Keystone = new SlotRune(4);

            //비열한 한 방, 피의 맛, 돌발 일격
            Slot1 = new SlotRune(3);

            //좀비 와드, 유령 포로, 사냥의 증표
            Slot2 = new SlotRune(3);

            //굶주린 사냥꾼, 영리한 사냥꾼, 끈질긴 사냥꾼, 궁극의 사냥꾼
            Slot3 = new SlotRune(3);

            ShardSlot1 = new SlotRune(3); //적응형 능력치, 공격 속도, 스킬 가속
            ShardSlot2 = new SlotRune(3); //적응형 능력치, 방어력, 마법 저항력
            ShardSlot3 = new SlotRune(3); //체력, 방어력, 마법 저항력

            Keystone.Ids.AddRange(new[] {"Electrocute", "Predator", "Dark Harvest", "Hail of Blades"});

            Slot1.Ids.AddRange(new[] {"Cheap Shot", "Taste of Blood", "Sudden Impact"});
            Slot2.Ids.AddRange(new[] {"Zombie Ward", "Ghost Poro", "Eyeball Collection"});
            Slot3.Ids.AddRange(new[] {"Ravenous Hunter", "Ingenious Hunter", "Relentless Hunter", "Ultimate Hunter"});

            ShardSlot1.Ids.AddRange(new[] {"Adaptive", "Attack Speed", "Ability Haste"});
            ShardSlot2.Ids.AddRange(new[] {"Adaptive", "Armor", "Magic Resistance"});
            ShardSlot3.Ids.AddRange(new[] {"Health", "Armor", "Magic Resistance"});
        }
    }
}
