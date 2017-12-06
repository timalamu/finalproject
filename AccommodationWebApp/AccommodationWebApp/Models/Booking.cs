using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AccommodationWebApp.Models
{
    public enum RoomClass
    {
        Select,
        [Display(Name = "Ensuite Single")] EnsuiteSingle,
        [Display(Name = "Standard Single")] StandardSingle,
        [Display(Name = "Ensuite Twin")] EnsuiteTwin,
        [Display(Name = "Standard Twin")] StandardTwin
    }

    public enum BookingStatus { Select, Confirmed, [Display(Name = "Wait Listed")] WaitListed, Declined }

    public class Booking

    {
        const double RateEnsuiteSingle = 100;
        const double RateStandardSingle = 75;
        const double RateEnsuiteTwin = 180;
        const double RateStandardTwin = 140;

        [Key]
        [Display (Name ="Application No.")]
        public int ApplicationReferenceNo { get; set; }

        [Required]
        [Display (Name = "Student Number")]
        public int StudentId { get; set; }

        [Display (Name = "Date of Application")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfApplication { get; set; }

        [Required]
        [Display(Name = "Last or Family Name")]
        [StringLength(30, ErrorMessage = "Last name cannot be longer than 30 characters.")]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-za-z]+))$", ErrorMessage = "Enter valid character for First and Mid names")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(30, ErrorMessage = "First name cannot be longer than 30 characters.")]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-za-z]+))$", ErrorMessage = "Enter valid character for First and Mid names")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "E-Mail Address cannot be longer than 60 characters.")]
        [Display(Name = "E-Mail Address")]
        [DataType ("EMailAddress")]
        public string EMailAddress { get; set; }

        [Required]
        [Display (Name = "Year of Study")]
        public YearOfStudy YearOfStudy { get; set; }

        [Display (Name = "Contact Telephone")]
        public int ContactPhone { get; set; }

        [Required]
        [Display (Name = "Please check the box if you have been offerred and accepted accommodation before")]
        public bool PreviouslyAccommodated { get; set; }

        [Display (Name = "Room Type")]
        public RoomType RoomType { get; set; }

        [Display(Name = "Room No.")]
        public int RoomId { get; set; }

        [Display (Name = "Amount Due")]
        public Double AmountDue { get; set; }

        public BookingStatus BookingStatus { get; set; }

        public Student Student { get; set; }

        public Room Room { get; set; }

    }
}