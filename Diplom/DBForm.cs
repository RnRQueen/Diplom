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
        
        
        private void UpdateDataSource()
        {
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMain.DataSource = null;
            dgvMain.DataSource = DBHelper.Context.Apartaments.ToArray();
            dgvMain.Columns[0].Visible = false;
            dgvMain.Columns["Address"].HeaderText = "Адрес";
            dgvMain.Columns["Status"].HeaderText = "Статус";
            dgvMain.Columns["Date"].HeaderText = "Дата";
            dgvMain.Columns["Type"].HeaderText = "Тип";
            dgvMain.Columns["Price"].HeaderText = "Цена";
            dgvMain.Columns["NumRooms"].HeaderText = "Количество комнат";
            dgvMain.Columns["Type"].HeaderText = "Тип";
            dgvMain.Columns["Area"].HeaderText = "Площадь";
            dgvMain.Columns["Floor"].HeaderText = "Этаж";
            dgvMain.Columns["NumFloor"].HeaderText = "Этажность";
            dgvMain.Columns["Description"].HeaderText = "Описание";
            dgvMain.Columns["Phone"].HeaderText = "Телефон";
            dgvMain.Columns["Name"].HeaderText = "Имя";
            dgvMain.Columns["Link"].HeaderText = "Ссылка";
            dgvMain.Columns["Metro"].HeaderText = "Метро";
            dgvMain.Columns["MetroLine"].HeaderText = "Линия метро";
            dgvMain.Columns["Transport"].HeaderText = "Транспортом";
            dgvMain.Columns["Comment"].HeaderText = "Комментарии";
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            DBHelper.Context.SaveChanges();
            UpdateDataSource();
        }

      


    }
}
