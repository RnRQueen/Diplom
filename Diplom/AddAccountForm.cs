using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class AddAccountForm : Form
    {
        public AddAccountForm()
        {
            InitializeComponent();
            var site = new[] { "www.cian.ru" };
            cbSite.DataSource = site;
            

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            DBHelper.Context.Accounts.Add(
               new Accounts
               {
                   Website = cbSite.Text,
                   Login = tbLogin.Text ,
                   Password = tbPassword.Text
               });
            DBHelper.Context.SaveChanges();
            
            Close();
            

        }

       
        
           
       

        
      
    }
}
