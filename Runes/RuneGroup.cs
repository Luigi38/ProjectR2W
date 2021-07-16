using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectR2W.Runes
{
    public class RuneGroup
    {
        /// <summary>
        /// 정밀
        /// </summary>
        public PrecisionRune Precision { get; set; }

        /// <summary>
        /// 지배
        /// </summary>
        public DominationRune Domination { get; set; }
        
        /// <summary>
        /// 마법
        /// </summary>
        public SorceryRune Sorcery { get; set; }

        /// <summary>
        /// 결의
        /// </summary>
        public ResolveRune Resolve { get; set; }

        /// <summary>
        /// 영감
        /// </summary>
        public InspirationRune Inspiration { get; set; }
    }
}
