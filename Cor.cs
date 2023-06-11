using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisão_rosen
{
    internal class Cor : enumeration
    {
        private short[] branco { get; set; }
        private short[] preto { get; set; }

        public Cor()
        {
            branco = new short [3] {255,255,255};
            preto = new short[3] {0,0,0};
        }
    }
}
