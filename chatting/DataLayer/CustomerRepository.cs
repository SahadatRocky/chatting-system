using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataLayer
{
    public class CustomerRepository : ICustomerRepository
    {
        private DataContext context;

        public CustomerRepository() { this.context = new DataContext(); }

        public List<Customer> GetAll()
        {
            return this.context.customers.ToList();
        }

        //joining customer and room
        public List<Customer> GetAllData()
        {
            return this.context.customers.Include("Room").ToList();
        }


        public Customer Get(int id)
        {
            return this.context.customers.SingleOrDefault(d => d.C_Id == id);
        }

        //get data from two tables where customerid=?
        public Customer GetAllData(int id)
        {
            return this.context.customers.Include("Room").SingleOrDefault(d => d.C_Id == id);
        }

        public int Insert(Customer cust)
        {
            this.context.customers.Add(cust);
            return this.context.SaveChanges();
        }

        public int Update(Customer cust)
        {
            Customer custToUpdate = this.context.customers.SingleOrDefault(d => d.C_Id == cust.C_Id);
            custToUpdate.TotalAmount = cust.TotalAmount;
            custToUpdate.RoomId = cust.RoomId;
            return this.context.SaveChanges();
        }

        //update amount each time
        public int UpdateAmountEachTime(Customer cust)
        {
            Customer custToUpdate = this.context.customers.SingleOrDefault(d => d.C_Id == cust.C_Id);
            custToUpdate.TotalAmount += cust.TotalAmount;
            return this.context.SaveChanges();
        }

        public int Delete(int id)
        {
            Customer custToDelete = this.context.customers.SingleOrDefault(d => d.C_Id == id);
            this.context.customers.Remove(custToDelete);
            return this.context.SaveChanges();
        }
    }
}