using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataLayer
{
    public class RoomRepository : IRoomRepository
    {
        private DataContext context;

        public RoomRepository() { this.context = new DataContext(); }

        public List<Room> GetAll()
        {
            return this.context.rooms.ToList();
        }

        public Room Get(int id)
        {
            return this.context.rooms.SingleOrDefault(d => d.RoomId == id);
        }

        public int Insert(Room rm)
        {
            this.context.rooms.Add(rm);
            return this.context.SaveChanges();
        }



        public int Delete(int id)
        {
            Room deptToDelete = this.context.rooms.SingleOrDefault(d => d.RoomId == id);
            this.context.rooms.Remove(deptToDelete);
            return this.context.SaveChanges();
        }

       

        public int Update(Room rm)
        {
            Room rome = this.context.rooms.SingleOrDefault(d => d.RoomId == rm.RoomId);
            rome.RoomNumber = rm.RoomNumber;
            rome.Description = rm.Description;
            rome.Amount = rm.Amount;
            rome.Capacity = rm.Capacity;
            rome.Status = rm.Status;
            rome.Type = rm.Type;
            return this.context.SaveChanges();
        }

        //extra change each time
        public int UpdateChekIn(Room rm)
        {
            Room rome = this.context.rooms.SingleOrDefault(d => d.RoomId == rm.RoomId);
            rome.CheckIn = rm.CheckIn;
            rome.Checkout = rm.Checkout;
            return this.context.SaveChanges();
        }

        public int UpdateRome(Room rm)
        {
            Room rome = this.context.rooms.SingleOrDefault(d => d.RoomId == rm.RoomId);
            rome.Description = rm.Description;
            rome.Amount = rm.Amount;
            rome.Capacity = rm.Capacity;
            rome.Status = rm.Status;
            rome.Type = rm.Type;
            return this.context.SaveChanges();
        }




        //each time update when room booking
        public int UpdateStatus(Room rm)
        {
            Room rome = this.context.rooms.SingleOrDefault(d => d.RoomId == rm.RoomId);
            rome.Status = 0;
            return this.context.SaveChanges();
        }

        //new

        // public List<Room> SearchGetAll(DateTime date)
        //  {
        //    Room r1 = new Room();
        // DateTime d1 = r1.CheckIn;
        //    DateTime d2 = r1.Checkout;

        //  if (date < d1 && date > d2 || d1==null && d2==null ) {
        //    return this.context.Rooms.Where(d => d.Status == 1 ).ToList();
        //    }

        // return this.context.Rooms.Where(i => EntityFunctions.TruncateTime(i.CheckIn) == EntityFunctions.TruncateTime(date)).ToList();
        // }


        //use for take ll booking romes where customer id get
        public List<Room> GetAllBookingRoom(Customer cust)
        {
            return this.context.rooms.Include("Customer").Where(c => c.C_Id == cust.C_Id).ToList();
        }


    }
}