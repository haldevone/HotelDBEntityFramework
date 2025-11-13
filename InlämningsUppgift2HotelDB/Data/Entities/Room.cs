using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsUppgift2HotelDB.Data.Entities
{
    public class Room
    {
        [Key]
        public int RoomID { get; set; }

        [Required]
        [StringLength(30)]
        public string RoomType { get; set; } = "Enkelrum";

        [Required]
        [StringLength(20)]
        public int MaxBeds { get; set; }

        [Required]
        [StringLength(50)]
        public int RoomSize { get; set; }

        [Required]
        public bool RoomBooked { get; set; }

        [NotMapped]
        public string DisplayInfo
        {
            get { return $"{RoomType} - {MaxBeds} sängar - Rummets storlek {RoomSize}"; }
        }

    }
}
