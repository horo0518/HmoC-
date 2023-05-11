using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class FriendDto
    {
        [Required(ErrorMessage = "Id is required")]
        [Range(100000000, 999999999, ErrorMessage = "Id must be a 9-digit number")]
        public int Id { get; set; }


        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be between 2 and 50 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 50 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "City must be between 2 and 50 characters")]
        public string City { get; set; }

        [Required(ErrorMessage = "Street is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Street must be between 2 and 50 characters")]
        public string Street { get; set; }

        [Required(ErrorMessage = "NumStreet is required")]
        [Range(1, 10000, ErrorMessage = "NumStreet must be between 1 and 10000")]
        public int NumStreet { get; set; }

        [Required(ErrorMessage = "PhoneNumber is required")]
        [RegularExpression(@"^[0-9]{7,10}$", ErrorMessage = "PhoneNumber must be 7-10 digits")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "MobilePhone is required")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "MobilePhone must be 10 digits")]
        public string MobilePhone { get; set; }

        [Required(ErrorMessage = "Birthday is required")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "Picture is required")]
        [DataType(DataType.ImageUrl)]
        public string Picture { get; set; }
    }
}
