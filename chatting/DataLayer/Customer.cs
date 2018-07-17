using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DataLayer
{
    public class Customer
    {
        [Key]
        public int C_Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "name is required ")]
        public string C_Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "address is required ")]
        public string C_Address { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "phoneno is required ")]
        public int C_PhoneNo { get; set; }

        public int TotalAmount { get; set; }


        public int RoomId { get; set; }

        [ForeignKey("RoomId")]
        public Room Room { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }


    }
}