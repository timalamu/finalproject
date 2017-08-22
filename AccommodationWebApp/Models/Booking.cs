using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AccommodationWebApp.Models
{
    public enum Rooms
    {
        [Display(Name = "Ensuite Single")] EnsuiteSingle,
        [Display(Name = "Standard Single")] StandardSingle,
        [Display(Name = "Ensuite Twin")] EnsuiteTwin,
        [Display(Name = "Standard Twin")] StandardTwin
    }

    public class Booking

    {
        const double RateEnsuiteSingle = 100;
        const double RateStandardSingle = 75;
        const double RateEnsuiteTwin = 180;
        const double RateStandardTwin = 140;

        [Key]
        [Display (Name ="Application No.")]
        public int ApplicationReferenceNo { get; set; }

        [Display (Name = "Date of Application")]
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfApplication { get; set; }

        [Display (Name = "Room Type")]
        public Rooms RoomType { get; set; }

        [Display (Name = "Amount Due")]
        public Double AmountDue { get; set; }

        public Student Student { get; set; }

        public Room Room { get; set; }
    }
}