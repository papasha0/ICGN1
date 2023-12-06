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
    public partial class vopros1 : Form
    {
        public int k = 0;
        public string[] otveti = new string[14];
        public string[] ot1 = new string[4];
        public string[] ot2 = new string[4];
        public vopros1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Фишинг");
            comboBox1.Items.Add("Спам");
            comboBox1.Items.Add("Удалённый взлом");
            comboBox1.Items.Add("Ddos-атаки");
            comboBox2.Items.Add("Фишинг");
            comboBox2.Items.Add("Спам");
            comboBox2.Items.Add("Удалённый взлом");
            comboBox2.Items.Add("Ddos-атаки");
            comboBox3.Items.Add("Фишинг");
            comboBox3.Items.Add("Спам");
            comboBox3.Items.Add("Удалённый взлом");
            comboBox3.Items.Add("Ddos-атаки");
            comboBox4.Items.Add("Фишинг");
            comboBox4.Items.Add("Спам");
            comboBox4.Items.Add("Удалённый взлом");
            comboBox4.Items.Add("Ddos-атаки");
            otveti[2] = "otvet1";
            otveti[12] = "otvet2";
        }
        private void prov(int b)
        {
            if (b==0 || b == 1 || b == 3 || b == 5 || b == 8 || b == 9 || b == 11 || b == 13)
            {
                if (var1.Checked == true)
                {
                    otveti[b] = var1.Text;
                }
                if (var2.Checked == true)
                {
                    otveti[b] = var2.Text;
                }
                if (var3.Checked == true)
                {
                    otveti[b] = var3.Text;
                }
                if (var4.Checked == true)
                {
                    otveti[b] = var4.Text;
                }
            }
            if (b == 2)
            {
                if (logvar1.Checked == true)
                {
                    ot1[0] = logvar1.Text;
                }
                if (logvar2.Checked == true)
                {
                    ot1[1] = logvar2.Text;
                }
                if (logvar3.Checked == true)
                {
                    ot1[2] = logvar3.Text;
                }
                if (logvar4.Checked == true)
                {
                    ot1[3] = logvar4.Text;
                }
            }
            if (b == 4 || b == 6)
            {
                if (vvod1.Text == "")
                {
                    otveti[b] = " ";
                }
                else
                {
                    otveti[b] = vvod1.Text;
                }
            }
            if (b == 12)
            {
                if (comboBox1.Text != "")
                {
                    ot2[0] = comboBox1.Text;
                }
                if (comboBox2.Text != "")
                {
                    ot2[1] = comboBox2.Text;
                }
                if (comboBox3.Text != "")
                {
                    ot2[2] = comboBox3.Text;
                }
                if (comboBox4.Text != "")
                {
                    ot2[3] = comboBox4.Text;
                }
            }
            if (b == 10 || b == 7)
            {

                if (var1.Checked == true)
                {
                    otveti[b] = var1.Text;
                }
                if (var2.Checked == true)
                {
                    otveti[b] = var2.Text;
                }
            }
        }
        private void switc(int h)
        {
            switch (h)
            {
                case 0:
                    label1.BackColor = Color.Green;
                    break;
                case 1:
                    label2.BackColor = Color.Green;
                    break;
                case 2:
                    label3.BackColor = Color.Green;
                    break;
                case 3:
                    label4.BackColor = Color.Green;
                    break;
                case 4:
                    label5.BackColor = Color.Green;
                    break;
                case 5:
                    label6.BackColor = Color.Green;
                    break;
                case 6:
                    label7.BackColor = Color.Green;
                    break;
                case 7:
                    label8.BackColor = Color.Green;
                    break;
                case 8:
                    label9.BackColor = Color.Green;
                    break;
                case 9:
                    label10.BackColor = Color.Green;
                    break;
                case 10:
                    label11.BackColor = Color.Green;
                    break;
                case 11:
                    label12.BackColor = Color.Green;
                    break;
                case 12:
                    label13.BackColor = Color.Green;
                    break;
                case 13:
                    label14.BackColor = Color.Green;
                    break;
            }
        }
        private void vis1()
        {
            var1.Visible = true;
            var2.Visible = true;
            var3.Visible = true;
            var4.Visible = true;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            vvod1.Visible = false;
            logvar1.Visible = false;
            logvar2.Visible = false;
            logvar3.Visible = false;
            logvar4.Visible = false;
            back1.Visible = true;
        }
        private void vis2()
        {
            var1.Visible = false;
            var2.Visible = false;
            var3.Visible = false;
            var4.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            vvod1.Visible = false;
            logvar1.Visible = true;
            logvar2.Visible = true;
            logvar3.Visible = true;
            logvar4.Visible = true;
            back1.Visible = true;
        }
        private void vis3()
        {
            var1.Visible = false;
            var2.Visible = false;
            var3.Visible = false;
            var4.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            vvod1.Visible = true;
            logvar1.Visible = false;
            logvar2.Visible = false;
            logvar3.Visible = false;
            logvar4.Visible = false;
            back1.Visible = true;
        }
        private void vis4()
        {
            var1.Visible = true;
            var2.Visible = true;
            var3.Visible = false;
            var4.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            vvod1.Visible = false;
            logvar1.Visible = false;
            logvar2.Visible = false;
            logvar3.Visible = false;
            logvar4.Visible = false;
            back1.Visible = true;
        }
        private void vis5()
        {
            var1.Visible = true;
            var2.Visible = true;
            var3.Visible = true;
            var4.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
            comboBox4.Visible = true;
            vvod1.Visible = false;
            logvar1.Visible = false;
            logvar2.Visible = false;
            logvar3.Visible = false;
            logvar4.Visible = false;
            back1.Visible = true;
        }
        private void zap1(int d)
        {
            if(d == 0 || d == 1 || d == 3 || d == 5 || d == 8 || d == 9 || d == 11 || d == 13)
            {
                if(otveti[d] == var1.Text)
                {
                    var1.Checked = true;
                }
                if(otveti[d] == var2.Text)
                {
                    var2.Checked = true;
                }
                if (otveti[d] == var3.Text)
                {
                    var3.Checked = true;
                }
                if (otveti[d] == var4.Text)
                {
                    var4.Checked = true;
                }
            }
            if(d == 2)
            {
                if(otveti[d] != "")
                {
                    if (ot1[0] == logvar1.Text)
                    {
                        logvar1.Checked = true;
                    }
                    if (ot1[1] == logvar2.Text)
                    {
                        logvar2.Checked = true;
                    }
                    if (ot1[2] == logvar3.Text)
                    {
                        logvar3.Checked = true;
                    }
                    if (ot1[3] == logvar4.Text)
                    {
                        logvar4.Checked = true;
                    }
                }
            }
            if(d == 4 || d == 6)
            {
                vvod1.Text = otveti[d];
            }
            if(d == 12)
            {
                if(otveti[d] != "")
                {
                    comboBox1.Text = ot2[0];
                    comboBox2.Text = ot2[1];
                    comboBox3.Text = ot2[2];
                    comboBox4.Text = ot2[3];
                }
            }
            if(d == 7 || d == 10)
            {
                if (otveti[d] == var1.Text)
                {
                    var1.Checked = true;
                }
                if (otveti[d] == var2.Text)
                {
                    var2.Checked = true;
                }
            }
        }
        private void next1_Click(object sender, EventArgs e)
        {
            Voprosi vop = new Voprosi();
            prov(k);
            k++;
            if (k == 1 || k == 3 || k == 5  || k == 8 || k == 9 || k == 11 || k == 13)
            {
                text1.Text = vop.vopros[k][0];
                var1.Text = vop.vopros[k][1];
                var2.Text = vop.vopros[k][2];
                var3.Text = vop.vopros[k][3];
                var4.Text = vop.vopros[k][4];
                vis1();
                if (k == 1)
                {
                    label1.BackColor = Color.Green;
                }
                if (k == 3)
                {
                    label3.BackColor = Color.Green;
                }
                if (k == 5)
                {
                    label5.BackColor = Color.Green;
                }
                if (k == 8)
                {
                    label8.BackColor = Color.Green;
                }
                if (k == 9)
                {
                    label9.BackColor = Color.Green;
                }
                if (k == 11)
                {
                    label11.BackColor = Color.Green;
                }
                if (k == 13)
                {
                    next1.Text = "Завершить тестирование";
                    label13.BackColor = Color.Green;
                }
            }
            if( k == 2)
            {
                text1.Text = vop.vopros[k][0];
                logvar1.Text = vop.vopros[k][1];
                logvar2.Text = vop.vopros[k][2];
                logvar3.Text = vop.vopros[k][3];
                logvar4.Text = vop.vopros[k][4];
                vis2();
                label2.BackColor = Color.Green;
                otveti[k] = "";
            }
            if (k == 4 || k == 6)
            {
                text1.Text = vop.vopros[k][0];
                vis3();
                if (k == 4)
                {
                    label4.BackColor = Color.Green;
                }
                if (k == 6)
                {
                    label6.BackColor = Color.Green;
                }
            }
            if( k == 12)
            {
                text1.Text = vop.vopros[k][0];
                var1.Text = vop.vopros[k][1];
                var2.Text = vop.vopros[k][2];
                var3.Text = vop.vopros[k][3];
                var4.Text = vop.vopros[k][4];
                vis5();
                label12.BackColor = Color.Green;
            }
            if(k == 10 || k == 7)
            {
                text1.Text = vop.vopros[k][0];
                var1.Text = vop.vopros[k][1];
                var2.Text = vop.vopros[k][2];
                vis4();
                if (k == 10)
                {
                    label10.BackColor = Color.Green;
                }
                if (k == 7)
                {
                    label7.BackColor = Color.Green;
                }
            }
            if(k == 14)
            {
                prov(k - 1);
                label14.BackColor = Color.Green;
                new Otvet(otveti,ot1,ot2);
                Itog t = new Itog();
                t.Owner = this;
                timer1.Stop();
                t.Show();
                this.Hide();
            }
            zap1(k);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            switc(k);
            prov(k);
            vis1();
            text1.Text = "1.	Что такое центральный процессор (ЦП)? ";
            var1.Text = "Электронный блок либо интегральная схема, исполняющая машинные инструкции.";
            var2.Text = "Устройство, преобразующее графический образ, хранящийся как содержимое памяти компьютера, в форму, пригодную для дальнейшего вывода на экран монитора.";
            var3.Text = "Устройство, предназначенное для формирования напряжений питания компьютерных систем.";
            var4.Text = "Запоминающее устройство произвольного доступа, основанное на принципе магнитной записи.";
            next1.Text = "Следующий вопрос";
            k = 0;
            zap1(k);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            switc(k);
            prov(k);
            vis1();
            text1.Text = "2.	Как вы чистите свой компьютер?";
            var1.Text = "С помощью влажных тряпок или салфеток.";
            var2.Text = "Зачем его чистить?";
            var3.Text = "Протираю внешние элементы сухой салфеткой.";
            var4.Text = "Чищу внутренние и внешние части компьютера с помощью специальных чистящих средств.";
            next1.Text = "Следующий вопрос";
            k = 1;
            zap1(k);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            switc(k);
            prov(k);
            text1.Text = "3.	Из чего состоит персональный компьютер (ПК)? ";
            vis2();
            logvar1.Text = "Из материнской платы, сетевой карты, ЦП, Видеокарты и т.д.";
            logvar2.Text = "Из магии и любви.";
            logvar3.Text = "Устройств ввода и вывода, системного блока.";
            logvar4.Text = "из микросхем и магии.";
            next1.Text = "Следующий вопрос";
            k = 2;
            zap1(k);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            switc(k);
            prov(k);
            text1.Text = "4.	Что такое BIOS? ";
            vis1();
            var1.Text = "Программа управления внешним устройством компьютера.";
            var2.Text = "Набор микропрограмм, реализующих API для работы с аппаратурой компьютера и подключёнными к нему устройствами.";
            var3.Text = "Основной накопителель данных в большинстве компьютеров.";
            var4.Text = "Электронные и механические части вычислительного устройства.";
            next1.Text = "Следующий вопрос";
            k = 3;
            zap1(k);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            switc(k);
            prov(k);
            text1.Text = "5.	Часть пользовательского интерфейса Microsoft Windows, используемая для настройки системы (панель управления) ";
            vis3();
            next1.Text = "Следующий вопрос";
            k = 4;
            zap1(k);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            switc(k);
            prov(k);
            vis1();
            text1.Text = "6.	Как часто вы платите за интернет?";
            var1.Text = "1 раз в месяц.";
            var2.Text = "Я не плачу за него.";
            var3.Text = "1 раз в 6-12 месяцев.";
            var4.Text = "1 раз в несколько лет.";
            next1.Text = "Следующий вопрос";
            k = 5;
            zap1(k);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            switc(k);
            prov(k);
            text1.Text = "7.	Сколькими устройствами вы пользуетесь?";
            next1.Text = "Следующий вопрос";
            vis3();
            k = 6;
            zap1(k);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            switc(k);
            prov(k);
            text1.Text = "8.	Есть ли у вас персональный компьютер? ";
            next1.Text = "Следующий вопрос";
            vis4();
            var1.Text = "Да.";
            var2.Text = "Нет.";
            k = 7;
            zap1(k);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            switc(k);
            prov(k);
            vis1();
            text1.Text = "9.	Как часто вы пользуетесь компьютером? ";
            next1.Text = "Следующий вопрос";
            var1.Text = "Никогда";
            var2.Text = "почти никогда";
            var3.Text = "редко";
            var4.Text = "довольно-таки часто";
            k = 8;
            zap1(k);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            switc(k);
            prov(k);
            vis1();
            text1.Text = "10.	Вам пришло сообщение о выигрыше крупной суммы от неизвестного пользователя! Ваши действия: ";
            next1.Text = "Следующий вопрос";
            var1.Text = "Сообщить всем своим родственникам";
            var2.Text = "Отослать все необходимые данные";
            var3.Text = "IT'S A TRAP!";
            var4.Text = "Не стану ничего высылать, проигнорировав сообщение";
            k = 9;
            zap1(k);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            switc(k);
            prov(k);
            vis4();
            text1.Text = "11.	Есть ли у вас антивирус? ";
            next1.Text = "Следующий вопрос";
            var1.Text = "Да!";
            var2.Text = "Нет.";
            k = 10;
            zap1(k);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            switc(k);
            prov(k);
            vis1();
            text1.Text = "12.	Часто ли вы скачиваете файлы с незнакомых сайтов?";
            var1.Text = "Каждый раз, когда мне необходимы какие-либо файлы";
            var2.Text = "Я пользуюсь только официальными источниками";
            var3.Text = "Довольно редко скачиваю";
            var4.Text = "Стараюсь не скачивать файлы с незнакомых сайтов";
            next1.Text = "Следующий вопрос";
            k = 11;
            zap1(k);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            switc(k);
            prov(k);
            vis5();
            text1.Text = "13.	Сопоставьте различные виды киберугроз с их определениями: ";
            var1.Text = "Засорение электронной почты множеством писем";
            var2.Text = "Вид интернет-мошенничества, целью которого является получение доступа к конфиденциальным данным пользователей";
            var3.Text = "Взлом ПК из любой точки мира";
            var4.Text = "Специальным образом организованные массированные сетевые запросы";
            next1.Text = "Следующий вопрос";
            k = 12;
            zap1(k);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            switc(k);
            prov(k);
            vis1();
            text1.Text = "14.	Что делать если у вас взломали аккаунт?";
            var1.Text = "Обратиться в техподдержку, одновременно с этим меняя пароли на связанных с этим аккаунтами.";
            var2.Text = "Выполнить все условия мошенников.";
            var3.Text = "Игнорировать взлом.";
            var4.Text = "Удалить свой аккаунт.";
            next1.Text = "Завершить тестирование";
            k = 13;
            zap1(k);
        }

        private void back1_Click(object sender, EventArgs e)
        {
            prov(k);
            k--;
            Voprosi vop = new Voprosi();
            text1.Text = vop.vopros[k][0];
            if (k == 0 || k == 1 || k == 3 || k == 5 || k == 8 || k == 11 || k == 9)
            {
                var1.Text = vop.vopros[k][1];
                var2.Text = vop.vopros[k][2];
                var3.Text = vop.vopros[k][3];
                var4.Text = vop.vopros[k][4];
                vis1();
                next1.Text = "Следующий вопрос";
                if (k == 9)
                {
                    label11.BackColor = Color.Green;
                }
                if (k == 11)
                {
                    label13.BackColor = Color.Green;
                }
                if (k == 8)
                {
                    label10.BackColor = Color.Green;
                }
                if (k == 5)
                {
                    label7.BackColor = Color.Green;
                }
                if (k == 3)
                {
                    label5.BackColor = Color.Green;
                }
                if (k == 1)
                {
                    label3.BackColor = Color.Green;
                }
                if (k == 0)
                {
                    back1.Visible = false;
                    label2.BackColor = Color.Green;
                }
            }
            if (k == 2)
            {
                logvar1.Text = vop.vopros[k][1];
                logvar2.Text = vop.vopros[k][2];
                logvar3.Text = vop.vopros[k][3];
                logvar4.Text = vop.vopros[k][4];
                vis2();
                next1.Text = "Следующий вопрос";
                label4.BackColor = Color.Green;
            }
            if (k == 4 || k == 6)
            {
                vis3();
                next1.Text = "Следующий вопрос";
                if (k == 4)
                {
                    label6.BackColor = Color.Green;
                }
                if (k == 6)
                {
                    label8.BackColor = Color.Green;
                }
            }
            if (k == 12)
            {
                var1.Text = vop.vopros[k][1];
                var2.Text = vop.vopros[k][2];
                var3.Text = vop.vopros[k][3];
                var4.Text = vop.vopros[k][4];
                vis5();
                label14.BackColor = Color.Green;
                next1.Text = "Следующий вопрос";
            }
            if (k == 10 || k == 7)
            {
                var1.Text = vop.vopros[k][1];
                var2.Text = vop.vopros[k][2];
                vis4();
                next1.Text = "Следующий вопрос";
                if (k == 7)
                {
                    label9.BackColor = Color.Green;
                }
                if (k == 10)
                {
                    label12.BackColor = Color.Green;
                }
            }
            zap1(k);
        }

        private void vopros1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int h = 0;
        int m = 0;
        int s = 0;
        public double s2 = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            s2++;
            s++;
            string time = "";
            if (s > 59)
            {
                m++;
                s = 0;
            }
            if (m > 59)
            {
                h++;
                m = 0;
            }
            if (h < 10)
            {
                time += "0" + h;
            }
            else
            {
                time += h;
            }

            time += ":";

            if (m < 10)
            {
                time += "0" + m;
            }
            else
            {
                time += m;
            }

            time += ":";

            if (s < 10)
            {
                time += "0" + s;
            }
            else
            {
                time += s;
            }
            Timer.Text = time;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l < 'А' || l >= 'А') 
            {
                e.Handled = true;
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l < 'А' || l >= 'А')
            {
                e.Handled = true;
            }
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l < 'А' || l >= 'А')
            {
                e.Handled = true;
            }
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l < 'А' || l >= 'А')
            {
                e.Handled = true;
            }
        }
        //private void vopros1_Load(object sender, EventArgs e)
        //{
        //    timer1.Start();
        //}
        //DateTime date1 = new DateTime(0, 0);
        //private void timer1_Tick_1(object sender, EventArgs e)
        //{
        //    date1 = date1.AddSeconds(1);
        //    Timer.Text = date1.ToString("mm:ss");
        //}
    }
}
