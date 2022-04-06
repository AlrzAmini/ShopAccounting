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

namespace ShopAccounting
{
    public partial class frmGoods : Form
    {
        public frmGoods()
        {
            InitializeComponent();
        }

        private void frmGoods_Load(object sender, EventArgs e)
        {
            BindGoodsGrid();
            
        }

        public void BindGoodsGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgGoods.AutoGenerateColumns = false;
                dgGoods.DataSource = db.GoodsRepository.GetAllGoods();
            }
        }

        private void btnRefreshGoods_Click(object sender, EventArgs e)
        {
            txtFilterGoods.Text = "";
            BindGoodsGrid();
        }

        private void txtFilterCustomers_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgGoods.DataSource = db.GoodsRepository.GetGoodsByFilter(txtFilterGoods.Text);
            }
        }

        private void btnAddGood_Click(object sender, EventArgs e)
        {
            frmAddOrEditGood frmAdd = new frmAddOrEditGood();
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                BindGoodsGrid();
            }
        }

        private void btnDeleteGood_Click(object sender, EventArgs e)
        {
            if (dgGoods.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    int goodId = int.Parse(dgGoods.CurrentRow.Cells[0].Value.ToString());
                    db.GoodsRepository.DeleteGood(goodId);
                    db.Save();
                    BindGoodsGrid();
                }
            }
            else
            {
                MessageBox.Show("لطفا کالای مورد نظر راانتخاب کنید ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditGood_Click(object sender, EventArgs e)
        {
            if (dgGoods.CurrentRow !=null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    int goodid = int.Parse(dgGoods.CurrentRow.Cells[0].Value.ToString());
                    frmAddOrEditGood frmAddOrEditGood = new frmAddOrEditGood();
                    frmAddOrEditGood.GoodId = goodid;
                    //frmAddOrEditGood.ShowDialog();
                    if (frmAddOrEditGood.ShowDialog()== DialogResult.OK)
                    {
                        BindGoodsGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("لطفا کالا مورد نظر راانتخاب کنید ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
