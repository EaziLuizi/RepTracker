using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepTracker.Shared
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "First name is too long.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Last name is too long.")]
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Gender Gender { get; set; }
        public string Comment { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        [NotMapped]
        public byte[] ImageContent { get;set;}
        public string ImageName { get;set;}
    }
}
