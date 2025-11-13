using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsUppgift2HotelDB.Data.Entities
{
    
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerEmail { get; set; }

        [Required]
        [StringLength(20)]
        public int CustomerPhone { get; set; }



    }
}
