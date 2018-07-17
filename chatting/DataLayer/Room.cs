using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DataLayer
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "RoomNumber is required ")]

        public int RoomNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Description is required ")]
        public string Description { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Amount is required ")]
        public double Amount { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Capacity is required ")]

        public int Capacity { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Status is required ")]

        public int Status { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Type is required ")]

        public string Type { get; set; }

        //extra
        public DateTime CheckIn { get; set; }
        public DateTime Checkout { get; set; }

        public int C_Id { get; set; }
        [ForeignKey("C_Id")]
        public List<Customer> Customers { get; set; }


    }
}