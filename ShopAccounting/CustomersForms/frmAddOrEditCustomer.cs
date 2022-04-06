using Accounting.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace ShopAccounting.CustomersForms
{
    public partial class frmAddOrEditCustomer : Form
    {
        public int customerid = 0;
        public frmAddOrEditCustomer()
        {
            InitializeComponent();
        }

        private void btnSelectCustomerImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pcCustomer.ImageLocation = openFile.FileName; // ابن فایل دات فایل نیم مسیر عکسی هست که کاربر انتخاب میکنه که میدیمش به مسسیر \بکچرباکسمون 
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (BaseValidator.IsFormValid(this.components))
            {
                // برای ذخیره اسم عکس در بانک
                string ImageName = Guid.NewGuid().ToString() + Path.GetExtension(pcCustomer.ImageLocation); //   تولید یه عبارت منحصر به فرد برای اسم عکس و دستور گت اکستنشن برای گرفتن بسوند عکس
                                                                                                            // برای ذخیره خود عکس در بوشه بروژه                                                                                           
                string path = Application.StartupPath + "/Images/";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                pcCustomer.Image.Save(path + ImageName); // مسیر میگیره میبره ذخیره میکنه
                using (UnitOfWork db = new UnitOfWork())
                {
                    Customers customer = new Customers()
                    {
                        FullName = txtName.Text,
                        Mobile = txtMobile.Text,
                        Address = txtAddress.Text,
                        CustomerImage = ImageName

                    };
                    if (customerid == 0)
                    {
                        db.CustomerRepository.InsertCustomer(customer);
                    }
                    else
                    {
                        customer.CustomerID = customerid;
                        db.CustomerRepository.UpdateCustomer(customer);
                    }
                    
                    db.Save();
                    DialogResult = DialogResult.OK;

                }
            }

        }

        private void frmAddOrEditCustomer_Load(object sender, EventArgs e)
        {
            if (customerid != 0)
            {
                this.Text = "ویرایش مشتری";
                btnSave.Text = "ویرایش";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var customer = db.CustomerRepository.GetCustomerById(customerid);
                    txtName.Text = customer.FullName;
                    txtMobile.Text = customer.Mobile;
                    txtAddress.Text = customer.Address;
                    pcCustomer.ImageLocation = Application.StartupPath + "/Images/" + customer.CustomerImage;
                }
            }
        }
    }
}


