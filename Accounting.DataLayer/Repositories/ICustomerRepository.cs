using Accounting.ViewModel.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer
{
    public interface ICustomerRepository
    {
        List<Customers> GetAllCustomers();
        Customers GetCustomerById(int customerid);

        IEnumerable<Customers> GetCustomersByFilter(string parameter);
        bool InsertCustomer(Customers customer);

        bool UpdateCustomer(Customers customer);
        bool DeleteCustomer(Customers customer);
        bool DeleteCustomer(int customerid);

        List<ListCustomersViewModel> GetNameCustomers(string filter = "");
        int GetCustomerIdByName(string name);

        string GetCustomerNameById(int id);






    }
}
