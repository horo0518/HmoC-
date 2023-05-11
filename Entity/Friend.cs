using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class Friend
    {
        // properties

        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public int NumStreet { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        [Required]
        public int MobilePhone { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        public string Picture { get; set; }

    //    //validation attribute to limit the number of vaccinations to 4
    //    [VaccinationCount(4)]
    //    public virtual ICollection<Vaccination> Vaccinations { get; set; }
    //}

    //// custom validation attribute to limit the number of vaccinations
    //public class VaccinationCountAttribute : ValidationAttribute
    //{
    //    private readonly int _maxCount;

    //    public VaccinationCountAttribute(int maxCount)
    //    {
    //        _maxCount = maxCount;
    //    }

    //    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    //    {
    //        var vaccinations = (ICollection<Vaccination>)value;
    //        if (vaccinations != null && vaccinations.Count > _maxCount)
    //        {
    //            return new ValidationResult($"The maximum number of vaccinations allowed is {_maxCount}.");
    //        }

    //        return ValidationResult.Success;
    //    }
    }
}
