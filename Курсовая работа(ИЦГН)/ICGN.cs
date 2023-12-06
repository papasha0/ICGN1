using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа_ИЦГН_
{
    class ICGN:CK
    {
        private string[] veti;
        public string[] Veti
        {
            get
            {
                return veti;
            }
            set
            {
                veti = value;
            }
        }
        private string[] ot1;
        public string[] Ot1
        {
            get
            {
                return ot1;
            }
            set
            {
                ot1 = value;
            }
        }
        private string[] ot2;
        public string[] Ot2
        {
            get
            {
                return ot2;
            }
            set
            {
                ot2 = value;
            }
        }
        private double t;
        public double T
        {
            get
            {
                return t;
            }
            set
            {
                t = value;
            }
        }

        public ICGN(string[] cotveti,string[] cot1, string[] cot2, double timer)
        {
            Veti = cotveti;
            Ot1 = cot1;
            Ot2 = cot2;
            T = timer;
        }
        public double itograch()
        {
            double ktime = razd(t);
            double k1 = KCK(veti, ot1);
            double k2 = KCP(veti);
            double k3 = KCB(veti, ot2);
            double icgn = 0;
            icgn = ((k1 + k2 + k3) / 3) * 100 - 5 * ktime;
            return icgn;
        }
    }
}
