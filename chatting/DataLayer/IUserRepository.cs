using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   public interface IUserRepository
    {
        List<User> GetAll();
        User Get(int id);
        int Insert(User us);
        int Update(User us);
        int Delete(int id);
        User check_pass(User us);

    }
}
