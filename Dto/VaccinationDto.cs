using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class VaccinationDto
    {

        public int VaccineId { get; set; }//מספר חיסון כללי
        [Required]     
        [Range(100000000, 999999999, ErrorMessage = "FriendId must be a 9-digit number")]
        public int FriendId { get; set; }
        [Required]
        public DateTime DateGet { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "NameMaker must be between 3 and 50 characters")]
        public string NameMaker { get; set; }




    }
}
