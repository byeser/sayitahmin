using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cstech
{
    public class enums
    {
        /// <summary>
        /// puanlama kategorisi
        /// </summary>
        public enum puanlama : byte
        {
            /// <summary>
            /// sayıları basamak değerleri aynı iste artı puanına eklenir.
            /// </summary>
            arti,
            /// <summary>
            /// sayıların basamak değerleri farklı yerdeyse eksi puan eklenir.
            /// </summary>
            eksi
        }
    }
}
