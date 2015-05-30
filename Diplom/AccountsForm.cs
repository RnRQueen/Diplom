using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;



namespace Diplom
{
    public partial class AccountsForm : Form
    {
        public AccountsForm()
        {
           InitializeComponent();
           DBHelper.Context.Accounts.Load();
          dgvAccounts.DataSource = DBHelper.Context.Accounts.ToArray();
          dgvAccounts.Columns[0].Visible = false;
          dgvAccounts.Columns[3].Visible = false;
        }


       
    
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            {
                using (var f = new AddAccountForm())
                {
                    f.ShowDialog();
                    this.Show();
                }
                dgvAccounts.DataSource = null;
                dgvAccounts.DataSource = DBHelper.Context.Accounts.ToArray();
                dgvAccounts.Columns[0].Visible = false;
                dgvAccounts.Columns[3].Visible = false;
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvAccounts.SelectedRows)
            {
                Accounts account = row.DataBoundItem as Accounts;
                if (account != null)
                {
                    DBHelper.Context.Accounts.Remove(account);
                }
            }
            
            DBHelper.Context.SaveChanges();
            dgvAccounts.DataSource = null;
            dgvAccounts.DataSource = DBHelper.Context.Accounts.ToArray();
            dgvAccounts.Columns[0].Visible = false;
            dgvAccounts.Columns[3].Visible = false;
            
        }
        }
    
}
