using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AccommodationWebApp.Models
{
    public enum YearOfStudy { Select,
                            [Display (Name="1st Year")]FirstYear,
                            [Display(Name = "Final Year")]FinalYear,
                            Others }
    public class Student
    {   [Required]
    [Display (Name = "Student Number")]
        public int StudentId { get; set; }
        [Required]
        [Display (Name = "CAO Number")]
        public int CAONumber { get; set; }
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
        [Display (Name = "Please check the box if you have been oferred and accepted accommodation before")]
        public bool PreviouslyAccommodated { get; set; }

        public List<Booking> StudentBookings { get; set; }
    }
}