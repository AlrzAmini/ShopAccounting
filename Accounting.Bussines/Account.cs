using Accounting.DataLayer;
using Accounting.ViewModel.Accounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Bussines
{
    public class Account
    {
        public static ReportAccounting RepirtMainform()
        {
            ReportAccounting rp = new ReportAccounting();
            using (UnitOfWork db = new UnitOfWork())
            {
                DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
                DateTime endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);
                var recive = db.AccountingRepository.Get(s => s.TypeID == 1 && s.Date >= startDate && s.Date <= endDate).Select(s => s.Amount).ToList();
                var pay = db.AccountingRepository.Get(s => s.TypeID == 2 && s.Date >= startDate && s.Date <= endDate).Select(s => s.Amount).ToList();
                int Rcv = recive.Sum();
                rp.Recive = Rcv;
                int Py = pay.Sum();
                rp.Pay = Py;
                rp.Balance = Rcv - Py;
            }
            return rp;
        }
    }
}
