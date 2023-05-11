using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class SickDto
    {

        [Required(ErrorMessage = "FriendId is required")]
        [Range(100000000, 999999999, ErrorMessage = "FriendId must be a 9-digit number")]
        public int FriendId { get; set; }


        [Required]
        public DateTime GetPositive { get; set; }
        [Required]
        public DateTime DateOfRecovery { get; set; }
    }
}
