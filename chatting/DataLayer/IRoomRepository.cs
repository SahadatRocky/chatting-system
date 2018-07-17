using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   public interface IRoomRepository
    {
        List<Room> GetAll();
        Room Get(int id);
        int Insert(Room rm);
        int Update(Room rm);
        int Delete(int id);


    }
}
