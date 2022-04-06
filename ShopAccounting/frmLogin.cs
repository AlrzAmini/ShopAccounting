using Accounting.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace ShopAccounting
{
    public partial class frmLogin : Form
    {
        public bool isEdit = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                Application.Exit();
            }
            else
            {
                Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var login = db.LoginRepository.Get().First();
                    login.UserName = txtUserName.Text;
                    login.Password = txtpassword.Text;
                    db.LoginRepository.Update(login);
                    db.Save();
                    Application.Restart();
                }
               

            }
            else
            {
                if (BaseValidator.IsFormValid(this.components))
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        if (db.LoginRepository.Get(s => s.UserName == txtUserName.Text && s.Password == txtpassword.Text).Any())
                        {
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("رمز ورود یا نام کاربری را اشتباه وارد کرده اید", "نامعتبر", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                this.Text = "ویرایش رمز عبور";
                button1.Text = "ویرایش";
                using(UnitOfWork db = new UnitOfWork())
                {
                    var login = db.LoginRepository.Get().First();
                    txtUserName.Text = login.UserName;
                    txtpassword.Text = login.Password;
                    
                }
                 
            }
            
        }
    }
}
