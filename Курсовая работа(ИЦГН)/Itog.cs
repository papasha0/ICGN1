using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Курсовая_работа_ИЦГН_
{
    public partial class Itog : Form
    {
        SoundPlayer sndPlayer;
        public Itog()
        {
            InitializeComponent();
        }

        private void End_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            //f.Refresh();
            f.корректностьToolStripMenuItem.Enabled = true;
            f.Show();
            this.Hide();
        }

        private void Itog_Load_1(object sender, EventArgs e)
        {
            CK p1 = new CK();
            vopros1 v = this.Owner as vopros1;
            //Form1 f1 = this.Owner as Form1;
            ICGN I1 = new ICGN(v.otveti,v.ot1,v.ot2,v.s2);
            double k1 = p1.KCK(v.otveti, v.ot1);
            double k2 = p1.KCP(v.otveti);
            double k3 = p1.KCB(v.otveti, v.ot2);
            label3.Text = "ЦК: " + k1.ToString() + "/1";
            label4.Text = "ЦП: " + k2.ToString() + "/1";
            label5.Text = "ЦБ: " + k3.ToString() + "/1";
            label2.Text = "ИЦГН:" + "  " + Math.Round(I1.itograch()).ToString() + "%";
            Special.specicgn = Math.Round(I1.itograch(),0);
            chart1.Series[0].Points.AddXY("ЦК", k1);
            chart1.Series[0].Points.AddXY("ЦП", k2);
            chart1.Series[0].Points.AddXY("ЦБ", k3);
            Special.specot1 = v.ot1;
            Special.specot2 = v.ot2;
            Special.speotveti = v.otveti;
            int k = 2;
            Excell file = new Excell("C:\\Users\\d-les\\Downloads\\Курсовая работа(ИЦГН)\\Статистика.xlsx", 1);
            while (file.ReadCell(k, 1) != "")
            {
                k++;
            }
            file.WritetoCell(k, 1, Special.specPeople[0].Name);
            file.WritetoCell(k, 2, (Special.specPeople[0].Age).ToString());
            file.WritetoCell(k, 3, Special.specPeople[0].Sex);
            double[] t = new double[14];
            CK2 p2 = new CK2();
            var result1 = p2.KCK2(v.otveti, v.ot1);
            t[0] = result1.Item1;
            t[1] = result1.Item2;
            t[2] = result1.Item3;
            t[3] = result1.Item4;
            t[4] = result1.Item5;
            var result2 = p2.KCP2(v.otveti);
            t[5] = result2.Item1;
            t[6] = result2.Item2;
            t[7] = result2.Item3;
            t[8] = result2.Item4;
            var result3 = p2.KCB2(v.otveti,v.ot2);
            t[9] = result3.Item1;
            t[10] = result3.Item2;
            t[11] = result3.Item3;
            t[12] = result3.Item4;
            t[13] = result3.Item5;
            for (int i = 0; i < 14; i++)
            {
                file.WritetoCell(k, i + 4, (t[i]).ToString());
            }

            file.WritetoCell(k, 18, (k1).ToString());
            file.WritetoCell(k, 19, (k2).ToString());
            file.WritetoCell(k, 20, (k3).ToString());
            file.WritetoCell(k, 21, (I1.itograch()/100).ToString());
            //MessageBox.Show(file.ReadCell(21, 21));
            double finalitgn = 0;
            for (int m = k; m > 1; m--)
            {
                finalitgn += Convert.ToDouble(file.ReadCell(m, 21));
            }
            finalitgn = finalitgn / k;
            file.WritetoCell(2, 22, (finalitgn).ToString());
            file.Save();
            file.Close();
        }
    }
}
