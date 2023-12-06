using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Курсовая_работа_ИЦГН_
{
    class Excell
    {
            public string path; //путь
            _Application excel = new Excel.Application(); //создаём наше приложение
            Microsoft.Office.Interop.Excel.Workbook wb;
            Microsoft.Office.Interop.Excel.Worksheet ws;
            //Workbook wb; //книга
            //Worksheet ws; //страница
            public Worksheet ws1;
            public Worksheet ws2;
            public Worksheet ws3;
        public Excell(string path, int sheet)// открываем файл на нужной странице
            {
                this.path = path;
                wb = excel.Workbooks.Open(path);
                ws = wb.Worksheets[sheet];
            }
            public string ReadCell(int i, int j)// читаем значение/текст из ячейки
            {
                if (ws.Cells[i, j].Value2 != null)
                    return ws.Cells[i, j].Value2.ToString();
                else return "";
            }
        public void WritetoCell(int i,int j,string c)//записываем текст в ячейку
        {
            ws.Cells[i, j].Value2 = c;
        }
        public void Save()
        {
            wb.Save();
        }
        public void Close()
        {
            ws = null;
            wb.Close(false, false, false);
            excel.Quit();
            wb = null;
            excel = null;
            GC.Collect();
        }
        public void SaveAs(string path)
        {
            wb.SaveAs(path);
        }
    }
}
