using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа_ИЦГН_
{
    class Otvet:Uchastnik
    {
        private string[] cotveti = new string[14];
        private string[] cot1 = new string[4];
        private string[] cot2 = new string[4];
        public string[] Cot1
        {
            get
            {
                return cot1;
            }
            set
            {
                cot1 = value;
            }
        }
        public string[] Cot2
        {
            get
            {
                return cot2;
            }
            set
            {
                cot2 = value;
            }
        }
        public string[] Cotveti
        {
            get
            {
                return cotveti;
            }
            set
            {
                cotveti = value;
            }
        }
        public Otvet(string[] cotveti,string[] ot1,string[] ot2)
        {
            Cotveti = cotveti;
            Cot1 = ot1;
            Cot2 = ot2;
        }
        public Otvet()
        { }
        public double razd(double timer)
        {
            double ktime = 0;
            if(timer > 600)
            {
                ktime = 1;
            }
            return ktime;
        }
    }
}
