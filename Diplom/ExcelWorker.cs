using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace Diplom
{
    public static class ExcelWorker
    {

        private static Application ObjExcel;
        static Workbook ObjWorkBook;
        static Worksheet objWorkSheet;
        static Worksheet ObjWorkSheet
        {
            get
            {
                if (objWorkSheet == null)
                {
                    ObjExcel = new Application();
                    ObjWorkBook = ObjExcel.Workbooks.Add(Missing.Value);
                    objWorkSheet = (Worksheet)ObjWorkBook.ActiveSheet;
                }
                return objWorkSheet;
            }
        }

        private static void AddHeader()
        {
            ObjWorkSheet.Cells[1, 1] = "Адрес";
            ObjWorkSheet.Cells[1, 2] = "Статус/конкуренция";
            ObjWorkSheet.Cells[1, 3] = "Дата";
            ObjWorkSheet.Cells[1, 4] = "Тип";
            ObjWorkSheet.Cells[1, 5] = "Цена";
            ObjWorkSheet.Cells[1, 6] = "Кол-во комнат";
            ObjWorkSheet.Cells[1, 7] = "Площадь";
            ObjWorkSheet.Cells[1, 8] = "Этаж";
            ObjWorkSheet.Cells[1, 9] = "Этажность";
            ObjWorkSheet.Cells[1, 10] = "Описание";
            ObjWorkSheet.Cells[1, 11] = "Телефон";
            ObjWorkSheet.Cells[1, 12] = "Имя";
            ObjWorkSheet.Cells[1, 13] = "Ссылка";
            ObjWorkSheet.Cells[1, 14] = "Метро";
            ObjWorkSheet.Cells[1, 15] = "Ветка метро";
            ObjWorkSheet.Cells[1, 16] = "Транспортом";
            ObjWorkSheet.Cells[1, 17] = "Комментарии";
        }

        public static void Export(ApartmentData[] apartments)
        {
            AddHeader();

            for (int i = 1; i <= apartments.Length; i++)
            {
                var apartment = apartments[i - 1];
                var j = i + 1;
                ObjWorkSheet.Cells[j, 1] = apartment.Address;
                ObjWorkSheet.Cells[j, 2] = apartment.Status;
                ObjWorkSheet.Cells[j, 3] = apartment.Date;
                ObjWorkSheet.Cells[j, 4] = apartment.Type;
                ObjWorkSheet.Cells[j, 5] = apartment.Price;
                ObjWorkSheet.Cells[j, 6] = apartment.NumRooms;
                ObjWorkSheet.Cells[j, 7] = apartment.Area;
                ObjWorkSheet.Cells[j, 8] = apartment.Floor;
                ObjWorkSheet.Cells[j, 9] = apartment.NumFloor;
                ObjWorkSheet.Cells[j, 10] = apartment.Description;
                ObjWorkSheet.Cells[j, 11] = apartment.Phone;
                ObjWorkSheet.Cells[j, 12] = apartment.Name;
                ObjWorkSheet.Cells[j, 13] = apartment.Link;
                ObjWorkSheet.Cells[j, 14] = apartment.Metro;
                ObjWorkSheet.Cells[j, 15] = apartment.MetroLine;
                ObjWorkSheet.Cells[j, 16] = apartment.Transport;
                ObjWorkSheet.Cells[j, 17] = apartment.Comment;

            }
            //Вызываем нашу созданную эксельку.
            ObjExcel.Visible = true;
            ObjExcel.UserControl = true;
        }

        public static ApartmentData[] Import()
        {
            var res = new List<ApartmentData>();
            using (var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //Создаём приложение.
                    var ObjExcel = new Application();
                    //Открываем книгу.                                                                                                                                                        
                    var ObjWorkBook = ObjExcel.Workbooks.Open(ofd.FileName,
                                                                          0, false, 5, "", "", false, XlPlatform.xlWindows, "", true,
                                                                          false, 0, true, false, false);
                    //Выбираем таблицу(лист).
                    Worksheet ObjWorkSheet;
                    ObjWorkSheet = (Worksheet)ObjWorkBook.ActiveSheet;


                    //Выбираем первые сто записей из столбца.
                    for (int i = 2; i < ObjWorkSheet.UsedRange.Rows.Count; i++)
                    {
                        var apartment = new ApartmentData
                        {
                            Address = Convert.ToString(((Range) ObjWorkSheet.Cells[i, 1]).Value2),
                            Status = Convert.ToString(((Range) ObjWorkSheet.Cells[i, 2]).Value2),
                            Date = Convert.ToString(((Range) ObjWorkSheet.Cells[i, 3]).Value2),
                            Type = Convert.ToString(((Range) ObjWorkSheet.Cells[i, 4]).Value2),
                            Price = Convert.ToInt32(((Range) ObjWorkSheet.Cells[i, 5]).Value2),
                            NumRooms = Convert.ToInt32(((Range) ObjWorkSheet.Cells[i, 6]).Value2),
                            Area = Convert.ToInt32(((Range) ObjWorkSheet.Cells[i, 7]).Value2),
                            Floor = Convert.ToInt32(((Range) ObjWorkSheet.Cells[i, 8]).Value2),
                            NumFloor = Convert.ToInt32(((Range) ObjWorkSheet.Cells[i, 9]).Value2),
                            Description = Convert.ToString(((Range) ObjWorkSheet.Cells[i, 10]).Value2),
                            Phone = Convert.ToString(((Range) ObjWorkSheet.Cells[i, 11]).Value2),
                            Name = Convert.ToString(((Range) ObjWorkSheet.Cells[i, 12]).Value2),
                            Link = Convert.ToString(((Range) ObjWorkSheet.Cells[i, 13]).Value2),
                            Metro = Convert.ToString(((Range) ObjWorkSheet.Cells[i, 14]).Value2),
                            MetroLine = Convert.ToString(((Range) ObjWorkSheet.Cells[i, 15]).Value2),
                            Transport = Convert.ToString(((Range) ObjWorkSheet.Cells[i, 16]).Value2),
                            Comment = Convert.ToString(((Range) ObjWorkSheet.Cells[i, 17]).Value2)
                        };
                        res.Add(apartment);
                    }
                    //Удаляем приложение (выходим из экселя) - а то будет висеть в процессах!
                    ObjExcel.Quit();
                }
            }
            return res.ToArray();
        }

        public static void Dispose()
        {
            if (ObjExcel != null && ObjExcel.Visible == false)
                ObjExcel.Quit();
        }
    }

}
