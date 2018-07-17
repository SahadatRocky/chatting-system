using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataLayer
{
    public class UserRepository : IUserRepository
    {
        private DataContext db;

        public UserRepository()
        {
            this.db = new DataContext();
        }

        public User check_pass(User us)
        {
            return db.users.SingleOrDefault(u => u.Username == us.Username && u.Password == us.Password);

        }

        public int Delete(int id)
        {
            User userToDelete = this.db.users.SingleOrDefault(e => e.UserId == id);
            this.db.users.Remove(userToDelete);

            return this.db.SaveChanges();
        }




        public User Get(int id)
        {
            return this.db.users.SingleOrDefault(e => e.UserId == id);
        }

        public List<User> GetAll()
        {
            return this.db.users.ToList();
        }

        public int Insert(User us)
        {

            db.users.Add(us);
            return this.db.SaveChanges();
        }

        public int Update(User us)
        {
            User userToUpdate = this.db.users.SingleOrDefault(e => e.UserId == us.UserId);
            userToUpdate.Username = us.Username;
            userToUpdate.Email = us.Email;
            userToUpdate.FirstName = us.FirstName;
            userToUpdate.LastName = us.LastName;
            userToUpdate.Password = us.Password;
            userToUpdate.ConfirmPassword = us.ConfirmPassword;
            userToUpdate.UserType = us.UserType;

            return this.db.SaveChanges();
        }


    }
}