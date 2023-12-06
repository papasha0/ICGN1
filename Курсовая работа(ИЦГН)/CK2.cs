using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа_ИЦГН_
{
    class CK2: Otvet
    {
        public CK2()
        { }
        public Tuple <double,double ,double ,double ,double> KCK2(string[] cotveti, string[] cot1)
        {
            double t1 = 0;
            double t2 = 0;
            double t3 = 0;
            double t4 = 0;
            double t5 = 0;
            if (cotveti[0] == "Электронный блок либо интегральная схема, исполняющая машинные инструкции.")
            {
                t1 = 1;
            }
            if (cotveti[1] == "Чищу внутренние и внешние части компьютера с помощью специальных чистящих средств.")
            {
                t2 = 1;
            }
            if (cot1[0] == "Из материнской платы, сетевой карты, ЦП, Видеокарты и т.д.")
            {
                t3 += 0.5;
            }
            if (cot1[2] == "Устройств ввода и вывода, системного блока.")
            {
                t3 += 0.5;
            }
            if (cotveti[3] == "Набор микропрограмм, реализующих API для работы с аппаратурой компьютера и подключёнными к нему устройствами.")
            {
                t4 = 1;
            }
            if (cotveti[4] == "панель управления")
            {
                t5 = 1;
            }
            return new Tuple<double, double, double, double, double>(t1,t2,t3,t4,t5);
        }
        public Tuple<double, double, double, double> KCP2(string[] cotveti)
        {
            double t6 = 0;
            double t7 = 0;
            double t8 = 0;
            double t9 = 0;
            if (cotveti[5] == "1 раз в месяц.")
            {
                t6 = 1;
            }
            if (cotveti[6] == "3" || cotveti[6] == "4" || cotveti[6] == "5" || cotveti[6] == "6" || cotveti[6] == "7" || cotveti[6] == "8" || cotveti[6] == "9" || cotveti[6] == "10")
            {
                t7 = 1;
            }
            if (cotveti[7] == "Да.")
            {
                t8 = 1;
            }
            if (cotveti[8] == "довольно-таки часто")
            {
                t9 = 1;
            }
            return new Tuple<double, double, double, double>(t6, t7, t8, t9);
        }
        public Tuple<double, double, double, double, double> KCB2(string[] cotveti, string[] cot2)
        {
            double t10 = 0;
            double t11 = 0;
            double t12 = 0;
            double t13 = 0;
            double t14 = 0;
            if (cotveti[9] == "Не стану ничего высылать, проигнорировав сообщение" || cotveti[9] == "IT'S A TRAP!")
            {
                t10 = 1;
            }
            if (cotveti[10] == "Да!")
            {
                t11 = 1;
            }
            if (cotveti[11] == "Я пользуюсь только официальными источниками")
            {
                t12 = 1;
            }
            if (cot2[0] == "Спам")
            {
                t13 += 0.25;
            }
            if (cot2[1] == "Фишинг")
            {
                t13 += 0.25;
            }
            if (cot2[2] == "Удалённый взлом")
            {
                t13 += 0.25;
            }
            if (cot2[3] == "Ddos-атаки")
            {
                t13 += 0.25;
            }
            if (cotveti[13] == "Обратиться в техподдержку, одновременно с этим меняя пароли на связанных с этим аккаунтами.")
            {
                t14 += 1;
            }
            return new Tuple<double, double, double, double,double>(t10, t11, t12, t13,t14);
        }
    }
}
