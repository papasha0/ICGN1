using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа_ИЦГН_
{
    public partial class Korrektor : Form
    {
        public Korrektor()
        {
            InitializeComponent();
        }
        int x = 0;
        private void next2_Click(object sender, EventArgs e)
        {
            Voprosi vop = new Voprosi();
            x++;
            if(x == 1 || x == 3 || x == 5 || x == 8 || x == 9 || x == 11 || x == 13)
            {
                vopros.Text = vop.vopros[x][0];
                var1.Text = "Вариант1:" + " " + vop.vopros[x][1];
                var2.Text = "Вариант2:" + " " + vop.vopros[x][2];
                var3.Text = "Вариант3:" + " " + vop.vopros[x][3];
                var4.Text = "Вариант4:" + " " + vop.vopros[x][4];
                Vash.Text = "Ваш ответ:" + " " + Special.speotveti[x];
                var1.Visible = true;
                var2.Visible = true;
                var3.Visible = true;
                var4.Visible = true;
                if(x == 1)
                {
                    Prav.Text = "Правильный ответ:" + " " + "Чищу внутренние и внешние части компьютера с помощью специальных чистящих средств.";
                }
                if (x == 3)
                {
                    Prav.Text = "Правильный ответ:" + " " + "Набор микропрограмм, реализующих API для работы с аппаратурой компьютера и подключёнными к нему устройствами.";
                }
                if (x == 5)
                {
                    Prav.Text = "Правильный ответ:" + " " + "1 раз в месяц.";
                }
                if (x == 8)
                {
                    Prav.Text = "Правильный ответ:" + " " + "довольно-таки часто";
                }
                if (x == 9)
                {
                    Prav.Text = "Правильный ответ:" + " " + "IT'S A TRAP! или Не стану ничего высылать, проигнорировав сообщение";
                }
                if (x == 11)
                {
                    Prav.Text = "Правильный ответ:" + " " + "Я пользуюсь только официальными источниками";
                }
                if (x == 13) 
                {
                    Prav.Text = "Правильный ответ:" + " " + "Обратиться в техподдержку, одновременно с этим меняя пароли на связанных с этим аккаунтами.";
                    next2.Text = "Завершить просмотр";
                }
            }
            if(x == 7 || x == 10)
            {
                vopros.Text = vop.vopros[x][0];
                var1.Text = "Вариант1:" + " " + vop.vopros[x][1];
                var2.Text = "Вариант2:" + " " + vop.vopros[x][2];
                Vash.Text = "Ваш ответ:" + " " + Special.speotveti[x];
                var1.Visible = true;
                var2.Visible = true;
                var3.Visible = false;
                var4.Visible = false;
                if (x == 7)
                {
                    Prav.Text = "Правильный ответ:" + " " + "Да.";
                }
                else
                {
                    Prav.Text = "Правильный ответ:" + " " + "Да!";
                }
            }
            if(x == 4)
            {
                vopros.Text = vop.vopros[x][0];
                Prav.Text = "Правильный ответ:" + " " + "панель управления";
                Vash.Text = "Ваш ответ:" + " " + Special.speotveti[x];
                var1.Visible = false;
                var2.Visible = false;
                var3.Visible = false;
                var4.Visible = false;
            }
            if (x == 6)
            {
                vopros.Text = vop.vopros[x][0];
                Prav.Text = "Правильный ответ:" + " " + ">3 и <12";
                Vash.Text = "Ваш ответ:" + " " + Special.speotveti[x];
                var1.Visible = false;
                var2.Visible = false;
                var3.Visible = false;
                var4.Visible = false;
            }
            if (x == 12)
            {
                vopros.Text = vop.vopros[x][0];
                var1.Text = "Вариант1:" + " " + vop.vopros[x][1];
                var2.Text = "Вариант2:" + " " + vop.vopros[x][2];
                var3.Text = "Вариант3:" + " " + vop.vopros[x][3];
                var4.Text = "Вариант4:" + " " + vop.vopros[x][4];
                var1.Visible = true;
                var2.Visible = true;
                var3.Visible = true;
                var4.Visible = true;
                Prav.Text = "Правильный ответ:" + " " + "1 - Спам, 2 - Фишинг, 3 - Удалённый взлом, 4 - Ddos-атака";
                Vash.Text = "Ваш ответ:" + " " + "1-" + Special.specot2[0]+ " " + "2-" + Special.specot2[1] + " " + "3-" + Special.specot2[2] + " " + "4-" + Special.specot2[3];
            }
            if(x == 2)
            {
                vopros.Text = vop.vopros[x][0];
                var1.Text = "Вариант1:" + " " + vop.vopros[x][1];
                var2.Text = "Вариант2:" + " " + vop.vopros[x][2];
                var3.Text = "Вариант3:" + " " + vop.vopros[x][3];
                var4.Text = "Вариант4:" + " " + vop.vopros[x][4];
                var1.Visible = true;
                var2.Visible = true;
                var3.Visible = true;
                var4.Visible = true;
                Prav.Text = "Правильный ответ:" + " " + "Из материнской платы, сетевой карты, ЦП, Видеокарты и т.д." + " " + "Устройств ввода и вывода, системного блока.";
                Vash.Text = "Ваш ответ:" + " " + Special.specot1[0] + " " + Special.specot1[2];
            }
            if (x == 14)
            {
                Form1 fo = new Form1();
                fo.корректностьToolStripMenuItem.Enabled = true;
                fo.Show();
                this.Hide();
            }
        }

        private void Korrektor_Load(object sender, EventArgs e)
        {
            Voprosi vop = new Voprosi();
            vopros.Text = vop.vopros[0][0];
            var1.Text = "Вариант1:" + " " + vop.vopros[0][1];
            var2.Text = "Вариант2:" + " " + vop.vopros[0][2];
            var3.Text = "Вариант3:" + " " + vop.vopros[0][3];
            var4.Text = "Вариант4:" + " " + vop.vopros[0][4];
            Vash.Text = "Ваш ответ:" + " " + Special.speotveti[0];
            Prav.Text = "Правильный ответ:" + " " + vop.vopros[0][1];
        }
    }
}
