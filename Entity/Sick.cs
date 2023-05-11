using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Sick
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SickId { get; set; }//מספר חולה כללי
        [Required]
        [ForeignKey("Friend")]
        public int FriendId { get; set; }
        [Required]  
        public DateTime GetPositive { get; set; }
        [Required]
        public DateTime DateOfRecovery { get; set; }
        
        public virtual Friend Friend { get; set; }
    }
}
