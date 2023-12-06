using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа_ИЦГН_
{
    public class Uchastnik
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        private string sex;
        public string Sex
        {
            get
            {
                return sex;
            }
            set
            {
                sex = value;
            }
        }
        public Uchastnik(string name, int age, string sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }
        public Uchastnik()
        {

        }
    }
}
