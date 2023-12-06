using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Курсовая_работа_ИЦГН_
{

    public partial class Statist : Form
    {
        public Statist()
        {
            InitializeComponent();
        }

        private void Statist_Load(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "*.xls;*.xlsx";
            ofd.Filter = "файл Excel (Spisok.xlsx)|*.xlsx";
            ofd.Title = "Выберите файл базы данных";
            if (ofd.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            Excel.Application kl = new Excel.Application();
            Excel.Workbook klBook = kl.Workbooks.Open(ofd.FileName,
            Type.Missing, true, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing);
            Excel.Worksheet klSheet = (Excel.Worksheet)klBook.Sheets[1];
            Excel.Worksheet klSheet2 = (Excel.Worksheet)klBook.Sheets[2];
            int i = 2;
            double z = 0;
            while (klSheet.Cells[i, 21].Text != "")
            {
                z = Convert.ToDouble(klSheet.Cells[i, 21].Value.ToString());
                chart1.Series[0].Points.AddXY(i-1,z);
                i++;
            }
            kl.Visible = true;
            kl.UserControl = true;
            klSheet = null;
            klBook.Close(false, false, false);
            kl.Quit();
            klBook = null;
            kl = null;
            GC.Collect();
        }
    }
}
