using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Accounting.ViewModel.Customers;

namespace Accounting.DataLayer
{
    public class CustomerRepository : ICustomerRepository
    {
        private ShopAccountingDBEntities db;

        public CustomerRepository(ShopAccountingDBEntities context)
        {
            db = context;
        }
        public List<Customers> GetAllCustomers()
        {
            return db.Customers.ToList();
        }
        public Customers GetCustomerById(int customerid)
        {
            return db.Customers.Find(customerid); // متد هایی که بهمون میده کلید اصلی رو هدف قرار میدن \س طبق اون کوعری میزنیم
        }
        public bool InsertCustomer(Customers customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch 
            {
                return false;
            }
        }
        
        public bool UpdateCustomer(Customers customer)
        {
            // دیگه نمیخام کوعری بزنم به بانک میخام همونجا عوضش کنم
            try
            {
                db.Entry(customer).State = EntityState.Modified;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(int customerid)
        {
            try
            {
                var Customer = GetCustomerById(customerid);
                DeleteCustomer(Customer);
                return true;
            }
            catch 
            {

                return false;
            }
            
        }

        

        public IEnumerable<Customers> GetCustomersByFilter(string parameter)
        {
            return db.Customers.Where(s => s.FullName.Contains(parameter) || s.Mobile.Contains(parameter) || s.Address.Contains(parameter)).ToList();
        }

        public List<ListCustomersViewModel> GetNameCustomers(string filter = "")
        {
            if (filter == "")
            {
                return db.Customers.Select(s => new ListCustomersViewModel() {FullName = s.FullName }).ToList();
            }
            return db.Customers.Where(s => s.FullName.Contains(filter)).Select(s => new ListCustomersViewModel() { FullName = s.FullName }).ToList();
        }

        public int GetCustomerIdByName(string name)
        {
            return db.Customers.First(s => s.FullName == name).CustomerID;
        }

        public string GetCustomerNameById(int id)
        {
            return db.Customers.Find(id).FullName;
        }
    }
}
