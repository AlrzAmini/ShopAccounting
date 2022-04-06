using Accounting.ViewModel.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer
{
    public interface IGoodsRepository
    {
        List<Goods> GetAllGoods();
        Goods GetGoodById(int goodid);

        bool InsertGood(Goods good);

        bool UpdateGood(Goods good);
        bool DeleteGood(Goods good);
        bool DeleteGood(int goodid);


        IEnumerable<Goods> GetGoodsByFilter(string parameter);
        List<ListCustomersViewModel> GetNameGoods(string filter = "");
        int GetGoodIdByName(string goodname);
        string GetGoodNameById(int id);
    }
}
