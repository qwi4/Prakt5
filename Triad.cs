using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt5
{
    internal class Triad
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Three { get; set; }
        public bool Srav(Triad triada)
        {
            bool what = false;
            if (First > triada.First || First == triada.First && Second > triada.Second && Three > triada.Three) what = true;
            return what;
        }

        public void SetParams()
        {
            First += 10;
            Second += 10;
            Three += 10;
        }
        public void SetParams(int first)
        {
            First = first;
        }
        public void SetParams(int first,int second)
        {
            First = first;
            Second = second;
        }
        public void SetParams(int first,int second,int three)
        {
            First = first;
            Second = second;
            Three = three;
        }
    }
}
