using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   public interface ICustomerRepository
    {
        List<Customer> GetAll();
        Customer Get(int id);
        int Insert(Customer cust);
        int Update(Customer cust);
        int Delete(int id);

        //Extra 3 
        List<Customer> GetAllData();
        Customer GetAllData(int id);
        int UpdateAmountEachTime(Customer cust);

    }
}
