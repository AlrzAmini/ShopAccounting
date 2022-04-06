using Accounting.ViewModel.Customers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services
{
    public class GoodsRepository : IGoodsRepository
    {
        private ShopAccountingDBEntities db;
        public GoodsRepository(ShopAccountingDBEntities context)
        {
            db = context;
        }

        

        public List<Goods> GetAllGoods()
        {
            return db.Goods.ToList();
        }

        

        public Goods GetGoodById(int goodid)
        {
            return db.Goods.Find(goodid);
        }

        public bool InsertGood(Goods good)
        {
            try
            {
                db.Goods.Add(good);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateGood(Goods good)
        {
            try
            {
                db.Entry(good).State = EntityState.Modified;

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteGood(Goods good)
        {
            try
            {
                db.Entry(good).State = EntityState.Deleted;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteGood(int goodid)
        {
            try
            {
                var Good = GetGoodById(goodid);
                DeleteGood(Good);
                return true;

            }
            catch 
            {

                return false;
            }
            
        }

        public IEnumerable<Goods> GetGoodsByFilter(string parameter)
        {
            return db.Goods.Where(s => s.GoodName.Contains(parameter) || s.GoodPrice.ToString().Contains(parameter)).ToList();
        }

        public List<ListCustomersViewModel> GetNameGoods(string filter = "")
        {
            if (filter == "")
            {
                return db.Goods.Select(s => new ListCustomersViewModel() { GoodName = s.GoodName }).ToList();
            }
            return db.Goods.Where(s => s.GoodName.Contains(filter)).Select(s => new ListCustomersViewModel() { GoodName = s.GoodName }).ToList();
        }

        public int GetGoodIdByName(string goodname)
        {
            return db.Goods.First(s => s.GoodName == goodname).GoodID;
        }

        public string GetGoodNameById(int id)
        {
            return db.Goods.Find(id).GoodName;
        }
    }
}
