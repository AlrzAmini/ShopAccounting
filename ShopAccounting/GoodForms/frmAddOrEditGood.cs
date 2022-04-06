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

namespace ShopAccounting
{
    public partial class frmAddOrEditGood : Form
    {
        public int GoodId = 0;
        public frmAddOrEditGood()
        {
            InitializeComponent();
        }

        private void frmAddOrEditGood_Load(object sender, EventArgs e)
        {
            if (GoodId !=0)
            {
                this.Text = "ویرایش کالا";
                btnSaveGood.Text = "ویرایش";
                using(UnitOfWork db = new UnitOfWork())
                {
                    var good = db.GoodsRepository.GetGoodById(GoodId);
                    txtGoodName.Text = good.GoodName;
                    txtGoodPrice.Value = good.GoodPrice;
                    pcGood.ImageLocation = Application.StartupPath + "/Images/" + good.GoodImage;
                }
            }
        }

        private void btnSelectGoodImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pcGood.ImageLocation = openFile.FileName; // ابن فایل دات فایل نیم مسیر عکسی هست که کاربر انتخاب میکنه که میدیمش به مسسیر \بکچرباکسمون 
            }
        }

        private void btnSaveGood_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                string ImageName = Guid.NewGuid().ToString() + Path.GetExtension(pcGood.ImageLocation);
                string path = Application.StartupPath + "/Images/";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                pcGood.Image.Save(path + ImageName); // مسیر میگیره میبره ذخیره میکنه
                using (UnitOfWork db = new UnitOfWork())
                {
                    
                    Goods good = new Goods()
                    {
                        GoodName = txtGoodName.Text,
                        GoodPrice = int.Parse(txtGoodPrice.Value.ToString()),
                        GoodImage = ImageName,
                        
                        
                    };
                    if (GoodId == 0)
                    {
                        db.GoodsRepository.InsertGood(good);
                    }
                    else
                    {
                        good.GoodID = GoodId;
                        db.GoodsRepository.UpdateGood(good);
                    }
                    
                    db.Save();
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
