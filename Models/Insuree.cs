using System;
using System.ComponentModel.DataAnnotations;

namespace ASPNetMVC_InsuranceQuote.Models
{
    public class Insuree
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public int CarYear { get; set; }

        [Required]
        public string CarMake { get; set; }

        [Required]
        public string CarModel { get; set; }

        [Required]
        public int SpeedingTickets { get; set; }

        [Required]
        public bool DUI { get; set; }

        [Required]
        public string CoverageType { get; set; }

        public decimal Quote { get; set; }
    }
}