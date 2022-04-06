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
using ShopAccounting.CustomersForms;

namespace ShopAccounting
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {

            BindGrid();
        }
        void BindGrid()
        {

            using (UnitOfWork db = new UnitOfWork())
            {
                dgCustomers.AutoGenerateColumns = false;
                dgCustomers.DataSource = db.CustomerRepository.GetAllCustomers();
            }
        }

        private void btnRefreshCustomers_Click(object sender, EventArgs e)
        {
            txtFilterCustomers.Text = "";
            BindGrid();
        }

        private void txtFilterCustomers_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgCustomers.DataSource = db.CustomerRepository.GetCustomersByFilter(txtFilterCustomers.Text);
            }

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgCustomers.CurrentRow != null)
            {
                // اول باید کاستومر آیدی اون خط رو بگیریم و کاستومر آیدی سلول صفرم اون خط هست
                if (dgCustomers.CurrentRow != null)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        string name = dgCustomers.CurrentRow.Cells[1].Value.ToString();
                        if (MessageBox.Show($"  آیا از حذف {name} مطمعن هستید ؟", "توجه", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            int customerId = int.Parse(dgCustomers.CurrentRow.Cells[0].Value.ToString());
                            db.CustomerRepository.DeleteCustomer(customerId);
                            db.Save();
                            BindGrid();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("لطفا شخص مورد نظر راانتخاب کنید ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddOrEditCustomer frmAdd = new frmAddOrEditCustomer();

            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgCustomers.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    //var customer = db.CustomerRepository.GetCustomerById(customerId);
                    int customerId = int.Parse(dgCustomers.CurrentRow.Cells[0].Value.ToString());
                    frmAddOrEditCustomer frmAddOrEditCustomer = new frmAddOrEditCustomer();
                    frmAddOrEditCustomer.customerid = customerId; // برای تعیین ادد یا ادیت بودن فرم 
                    frmAddOrEditCustomer.ShowDialog();
                    if (frmAddOrEditCustomer.DialogResult == DialogResult.OK) // اگه اکی برگردوند گرید رو بروز رسانی کن
                    {
                        BindGrid();
                    }

                    
                }
            }
            else
            {
                MessageBox.Show("لطفا شخص مورد نظر راانتخاب کنید ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
