using System.Collections.Generic;

namespace ProjectR2W.Runes
{
    public class SlotRune
    {
        public int Range { get; private set; }
        public int Value { get; set; }

        public List<string> Ids { get; set; } = new List<string>();

        public SlotRune(int range)
        {
            Range = range;
        }

        public SlotRune(int range, int value) : this(range)
        {
            Value = value;
        }
    }
}