using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа_ИЦГН_
{
    class CK:Otvet
    {
        public CK()
        { }
        public double KCK(string[] cotveti, string[] cot1)
        {
            double k1 = 0;
            if (cotveti[0] == "Электронный блок либо интегральная схема, исполняющая машинные инструкции.")
            {
                k1 += 0.2;
            }
            if (cotveti[1] == "Чищу внутренние и внешние части компьютера с помощью специальных чистящих средств.")
            {
                k1 += 0.2;
            }
            if (cot1[0] == "Из материнской платы, сетевой карты, ЦП, Видеокарты и т.д.")
            {
                k1 += 0.1;
            }
            if (cot1[2] == "Устройств ввода и вывода, системного блока.")
            {
                k1 += 0.1;
            }
            if (cotveti[3] == "Набор микропрограмм, реализующих API для работы с аппаратурой компьютера и подключёнными к нему устройствами.")
            {
                k1 += 0.2;
            }
            if (cotveti[4] == "панель управления")
            {
                k1 += 0.2;
            }
            return k1;
        }
        public double KCP(string[] cotveti)
        {
            double k2 = 0;
            if (cotveti[5] == "1 раз в месяц.")
            {
                k2 += 0.25;
            }
            if (cotveti[6] == "3" || cotveti[6] == "4" || cotveti[6] == "5" || cotveti[6] == "6" || cotveti[6] == "7" || cotveti[6] == "8" || cotveti[6] == "9" || cotveti[6] == "10")
            {
                k2 += 0.25;
            }
            if (cotveti[7] == "Да.")
            {
                k2 += 0.25;
            }
            if (cotveti[8] == "довольно-таки часто")
            {
                k2 += 0.25;
            }
            return k2;
        }
        public double KCB(string[] cotveti, string[] cot2)
        {
            double k3 = 0;
            if (cotveti[9] == "Не стану ничего высылать, проигнорировав сообщение" || cotveti[9] == "IT'S A TRAP!")
            {
                k3 += 0.2;
            }
            if (cotveti[10] == "Да!")
            {
                k3 += 0.2;
            }
            if (cotveti[11] == "Я пользуюсь только официальными источниками")
            {
                k3 += 0.2;
            }
            if (cot2[0] == "Спам")
            {
                k3 += 0.05;
            }
            if (cot2[1] == "Фишинг")
            {
                k3 += 0.05;
            }
            if (cot2[2] == "Удалённый взлом")
            {
                k3 += 0.05;
            }
            if (cot2[3] == "Ddos-атаки")
            {
                k3 += 0.05;
            }
            if (cotveti[13] == "Обратиться в техподдержку, одновременно с этим меняя пароли на связанных с этим аккаунтами.")
            {
                k3 += 0.2;
            }
            return k3;
        }
    }
}
