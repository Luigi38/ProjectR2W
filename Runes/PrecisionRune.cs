using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectR2W.Runes
{
    /// <summary>
    /// 룬 - 정밀
    /// </summary>
    public class PrecisionRune : IRune
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

        public PrecisionRune()
        {
            //집중 공격, 치명적 속도, 기민한 발놀림, 정복자
            Keystone = new SlotRune(4);

            //과다치유, 승전보, 침착
            Slot1 = new SlotRune(3);

            //전설: 민첩함, 전설: 강인함, 전설: 핏빛 길
            Slot2 = new SlotRune(3);

            //최후의 일격, 체력차 극복, 최후의 저항
            Slot3 = new SlotRune(3);

            ShardSlot1 = new SlotRune(3); //적응형 능력치, 공격 속도, 스킬 가속
            ShardSlot2 = new SlotRune(3); //적응형 능력치, 방어력, 마법 저항력
            ShardSlot3 = new SlotRune(3); //체력, 방어력, 마법 저항력

            Keystone.Ids.AddRange(new[] {"Press the Attack", "Lethal Tempo", "Fleet Footwork", "Conqueror"});

            Slot1.Ids.AddRange(new[] {"Overheal", "Triumph", "Presence of Mind"});
            Slot2.Ids.AddRange(new[] {"Legend: Alacrity", "Legend: Tenacity", "Legend: Bloodline"});
            Slot3.Ids.AddRange(new[] {"Coup de Grace", "Cut Down", "Last Stand"});
        }
    }
}
