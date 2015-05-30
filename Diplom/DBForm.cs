using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Diplom
{
    public partial class DBForm : Form
    {
        public DBForm()
        {
            InitializeComponent();
            DBHelper.Context.Apartaments.Load();
            UpdateDataSource();

        }
        
        private void btnRead_Click(object sender, EventArgs e)
        {

            DBHelper.Context.Apartaments.Load();
            UpdateDataSource();
        }

        private void UpdateDataSource()
        {
            dgvMain.DataSource = null;
            dgvMain.DataSource = DBHelper.Context.Apartaments.ToArray();
            dgvMain.Columns[0].Visible = false;
        }

        private void btnAddApartament_Click(object sender, EventArgs e)
        {
            using (var f = new AddApartamentForm())
            {
                f.ShowDialog();
            }
            UpdateDataSource();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in this.dgvMain.SelectedRows)
            {
                ApartmentData apartament = row.DataBoundItem as ApartmentData;
                if (apartament != null)
                {
                    DBHelper.Context.Apartaments.Remove(apartament);
                }
            }

            DBHelper.Context.SaveChanges();
            UpdateDataSource();
        }


    }
}
