using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Vaccination
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VaccineId { get; set; }//מספר חיסון כללי
        [Required]
        [ForeignKey("Friend")]
        public int FriendId { get; set; }
        [Required]
        public DateTime DateGet { get; set; }
        [Required]
        public string NameMaker { get; set; }
        public virtual Friend Friend {  get; set; }

      
    }
}
