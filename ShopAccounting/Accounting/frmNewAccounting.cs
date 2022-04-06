
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

using Accounting.DataLayer;

namespace ShopAccounting
{
    public partial class frmNewAccounting : Form
    {
        public int AccountId = 0;
        public frmNewAccounting()
        {
            InitializeComponent();
        }

        private void frmNewAccounting_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {


                ///////
                dgCustomersName.AutoGenerateColumns = false;
                dgCustomersName.DataSource = db.CustomerRepository.GetNameCustomers();
                dgGoodsName.AutoGenerateColumns = false;
                dgGoodsName.DataSource = db.GoodsRepository.GetNameGoods();
                ///////
                //if (txtNumber.Value !=0)
                //{
                //    int amount = int.Parse(dgGoodsName.CurrentRow.Cells[1].Value.ToString());
                //    int number = int.Parse(txtNumber.Value.ToString());
                //    txtAmount.Value = number * amount;
                //}

                // برای تشخیص ثبت یا ویرایش
                if (AccountId !=0)
                {
                    this.Text = "ویرایش تراکنش";
                    btnSave.Text = "ویرایش";
                    var account = db.AccountingRepository.GetById(AccountId);
                    txtAmount.Text = account.Amount.ToString();
                    txtDescription.Text = account.Description;
                    txtCustomerName.Text = db.CustomerRepository.GetCustomerNameById(account.CustomerID);
                    txtGoodName.Text = db.GoodsRepository.GetGoodNameById(account.GoodID);
                    if (account.TypeID == 1)
                    {
                        rbRecive.Checked = true;
                    }
                    else
                    {
                        rbPay.Checked = true;
                    }
                    
                }
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchCustomers_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgCustomersName.AutoGenerateColumns = false;
                dgCustomersName.DataSource = db.CustomerRepository.GetNameCustomers(txtSearchCustomers.Text);
            }
        }

        private void txtSearchGoods_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgGoodsName.AutoGenerateColumns = false;
                dgGoodsName.DataSource = db.GoodsRepository.GetNameGoods(txtSearchGoods.Text);
            }
        }

        private void dgCustomersName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerName.Text = dgCustomersName.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgGoodsName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGoodName.Text = dgGoodsName.CurrentRow.Cells[0].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNumber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (rbRecive.Checked || rbPay.Checked)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        Accounting.DataLayer.Accounting accounting = new Accounting.DataLayer.Accounting()
                        {

                            Amount = int.Parse(txtAmount.Value.ToString()),
                            CustomerID = db.CustomerRepository.GetCustomerIdByName(txtCustomerName.Text),
                            GoodID = db.GoodsRepository.GetGoodIdByName(txtGoodName.Text),
                            TypeID = (rbRecive.Checked) ? 1 : 2,
                            Date = DateTime.Now,
                            Description = txtDescription.Text

                        };
                        if (AccountId == 0)
                        {
                            db.AccountingRepository.Insert(accounting);
                        }
                        else
                        {
                            accounting.ID = AccountId;
                            db.AccountingRepository.Update(accounting);
                        }
                        
                        db.Save();
                        DialogResult = DialogResult.OK;

                    }
                }
                else
                {
                    MessageBox.Show("نوع تراکنش را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
