using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Range = Microsoft.Office.Interop.Word.Range;
using System.Drawing.Printing;

namespace Курсовая_работа_ИЦГН_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Uchastnik> People = new List<Uchastnik>();
        private string result = "";
        private void begin_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || age.Text == "" || (M.Checked == false && W.Checked == false))
            {
                MessageBox.Show("Пожалуйста, заполните данные о себе");
            }
            else
            {
                if(Convert.ToInt32(age.Text) <= 5)
                {
                    MessageBox.Show("Вы слишком молоды, чтобы проходить этот тест");
                }
                else
                {
                    People.Clear();
                    string n = name.Text;
                    int a = Convert.ToInt32(age.Text);
                    bool s = M.Checked;
                    string s3;
                    if (s == true)
                    {
                        s3 = "М";
                    }
                    else
                    {
                        s3 = "Ж";
                    }
                    People.Add(new Uchastnik(n, a, s3));
                    Special.specPeople = People;
                    vopros1 v1 = new vopros1();
                    v1.Show();
                    this.Hide();
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void age_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8) e.Handled = true;
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != '.' && l != '-')
            {
                e.Handled = true;
            }
        }

        private void посмотретьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statist st = new Statist();
            st.Show();
        }

        private void корректностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Korrektor kor = new Korrektor();
            kor.Show();
            this.Hide();
        }
    }
}
