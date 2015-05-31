using System;
using System.Linq;
using System.Windows.Forms;
using CianLib;
using Core;

namespace Diplom
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDB_Click(object sender, EventArgs e)
        {
            using (var f = new DBForm())
            {
                f.ShowDialog();
            }
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            ExcelWorker.Export(DBHelper.Context.Apartaments.ToArray());
        }

        private void btnExcelImport_Click(object sender, EventArgs e)
        {
            DBHelper.Context.Apartaments.AddRange(ExcelWorker.Import());
            DBHelper.Context.SaveChanges();
        }

        private void btnAccaunts_Click(object sender, EventArgs e)
        {
            using (var f = new AccountsForm())
            {
                f.ShowDialog();
            }
        }

        private void btnGetList_Click(object sender, EventArgs e)
        {
            var connector = new CianDataProvider();
            connector.GetData(new SearchFilter());
        }

       
    }
}
