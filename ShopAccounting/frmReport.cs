using Accounting.DataLayer;
using Accounting.Utility;
using Accounting.ViewModel.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopAccounting
{
    public partial class frmReport : Form
    {
        public int TypeID = 0;
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<ListCustomersViewModel> List = new List<ListCustomersViewModel>();

                List.Add(new ListCustomersViewModel()
                {
                    CustomerID = 0,
                    FullName = "انتخاب کنید",
                    //GoodID = 0,
                    //GoodName = "انتخاب کنید"
                }
                );
                List.AddRange(db.CustomerRepository.GetNameCustomers());
                cbCustomer.DataSource = List;
                cbCustomer.DisplayMember = "FullName";
                cbCustomer.ValueMember = "CustomerID";
                List<ListCustomersViewModel> GList = new List<ListCustomersViewModel>();
                GList.Add(new ListCustomersViewModel()
                {
                    //CustomerID = 0,
                    //FullName = "انتخاب کنید",
                    GoodID = 0,
                    GoodName = "انتخاب کنید"
                }
                );
                GList.AddRange(db.GoodsRepository.GetNameGoods());
                cbGood.DataSource = GList;
                cbGood.DisplayMember = "GoodName";
                cbGood.ValueMember = "GoodID";
            }
            if (TypeID == 1)
            {
                this.Text = "گزارش دریافتی ها";

            }
            else
            {

                this.Text = "گزارش پرداختی ها";
            }
            Filter();

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }

        void Filter() // برای پر کردن گرید ویو
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<Accounting.DataLayer.Accounting> result = new List<Accounting.DataLayer.Accounting>();
                DateTime? startDate;
                DateTime? endDate;
                if ((int)cbCustomer.SelectedValue != 0)
                {
                    int customerId = int.Parse(cbCustomer.SelectedValue.ToString());
                    result.AddRange(db.AccountingRepository.Get(a => a.TypeID == TypeID && a.CustomerID == customerId));
                }
                if ((int)cbGood.SelectedValue != 0)
                {
                    int goodId = int.Parse(cbGood.SelectedValue.ToString());
                    result.AddRange(db.AccountingRepository.Get(s => s.TypeID == TypeID && s.GoodID == goodId));
                }
                else
                {
                    result.AddRange(db.AccountingRepository.Get(s => s.TypeID == TypeID));
                }
                if (txtfromDate.Text != "    /  /")
                {
                    startDate = Convert.ToDateTime(txtfromDate.Text);
                    startDate = DateConvertor.ToMiladi(startDate.Value);
                    result = result.Where(r => r.Date >= startDate.Value).ToList();
                }
                if (txttoDate.Text != "    /  /")
                {
                    endDate = Convert.ToDateTime(txttoDate.Text);
                    endDate = DateConvertor.ToMiladi(endDate.Value);
                    result = result.Where(r => r.Date <= endDate.Value).ToList();
                }
                //var result = db.AccountingRepository.Get(s => s.TypeID == TypeID);
                //if ((int)cbCustomer.SelectedValue != 0)
                //{
                //    int customerId = int.Parse(cbCustomer.SelectedValue.ToString());
                //    result = db.AccountingRepository.Get(s => s.TypeID == TypeID && s.CustomerID == customerId);
                //}


                //var Result = db.AccountingRepository.Get(s => s.TypeID == TypeID);
                //dgReport.AutoGenerateColumns = false;
                //dgReport.DataSource = Result;
                dgReport.Rows.Clear();
                foreach (var accounting in result)
                {

                    string CustomerName = db.CustomerRepository.GetCustomerNameById(accounting.CustomerID);
                    string GoodName = db.GoodsRepository.GetGoodNameById(accounting.GoodID);
                    dgReport.Rows.Add(accounting.ID, CustomerName, GoodName, accounting.Amount, accounting.Description, accounting.Date.ToShamsi());

                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgReport.CurrentRow != null)
            {
                int id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
                if (MessageBox.Show("آیا از حذف مطمعن هستید ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.AccountingRepository.Delete(id);
                        db.Save();
                        Filter();
                    }
                }

            }
            else
            {
                MessageBox.Show("لطفا تراکنش مورد نظر را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgReport.CurrentRow != null)
            {
                frmNewAccounting frmNew = new frmNewAccounting();
                frmNew.AccountId = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
                if (frmNew.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }
            }
            else
            {
                MessageBox.Show("لطفا تراکنش مورد نظر را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dtPrint = new DataTable();
            dtPrint.Columns.Add("Customer");
            dtPrint.Columns.Add("Good");
            dtPrint.Columns.Add("Amount");
            dtPrint.Columns.Add("Description");
            dtPrint.Columns.Add("Date");
            foreach (DataGridViewRow item in dgReport.Rows) // برای پر کردن دیتا تیبل
            {
                // به تعداد و ترتیب ستونهامون تو گرید باید به این تیبل هم اضافه کنیم اطلاعات رو
                dtPrint.Rows.Add(
                    item.Cells[1].Value.ToString(), // customer
                    item.Cells[2].Value.ToString(), // good
                    item.Cells[3].Value.ToString(), // amount
                    item.Cells[4].Value.ToString(), // description
                    item.Cells[5].Value.ToString()  // date
                    );
                stiPrint.Load(Application.StartupPath + "/Report.mrt");
                stiPrint.RegData("DT", dtPrint);
                stiPrint.Show();
            }

        }
    }
}
