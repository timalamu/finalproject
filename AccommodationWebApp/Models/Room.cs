using AccommodationWebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AccommodationWebApp.Models
{
    public enum RoomType
    {
        [Display(Name = "Ensuite Single")] EnsuiteSingle,
        [Display (Name = "Standard Single")] StandardSingle,
        [Display(Name = "Ensuite Twin")] EnsuiteTwin,
        [Display(Name = "Standard Twin")] StandardTwin
    }

    public class Room
    {
        const double RateEnsuiteSingle = 100;
        const double RateStandardSingle = 75;
        const double RateEnsuiteTwin = 180;
        const double RateStandardTwin = 140;

        [Key]
        [Display (Name = "Room No.")]
        public int RoomId { get; set; }
        [Required]
        [Display (Name = "Room Type" )]
        public RoomType RoomType { get; set; }
        [Display (Name = "Available Quantity")]
        public int QuantityAvailable { get; set; }
        [Display (Name = "Room Rate")]
        public double AmountDue { get; set; } 
    
        public List<Booking> Bookings { get; set; }
    }

//}
//        {
//            get
//            {
//                double amount == RoomType;
//                if (amount == RateEnsuiteSingle)
//                {
//                    return RoomType.EnsuiteSingle;
//                }
//                else if (amount == RateStandardSingle)
//                {
//                    return BMICategory.Normal;
//                }
//                else if (bmi <= OverWeightUpperLimit)
//                {
//                    return BMICategory.OverWeight;
//                }
//                else
//                {
//                    return BMICategory.Obese;
//                }
//            }
    }


