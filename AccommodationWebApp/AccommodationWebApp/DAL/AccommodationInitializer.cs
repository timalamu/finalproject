using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AccommodationWebApp.Models;
using System.Globalization;

namespace AccommodationWebApp.DAL
{
    public class AccommodationInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AccommodationContext>
    {
        protected override void Seed(AccommodationContext context)
        {
            var students = new List<Student>
            {
            new Student{CAONumber = 1, LastName="Carson",FirstName="Alexander",EMailAddress="ac@gmail.com", YearOfStudy=YearOfStudy.FirstYear, ContactPhone=089955567, PreviouslyAccommodated = false},
            new Student{CAONumber = 2, LastName="Billy",FirstName="James",EMailAddress="bj@gmail.com", YearOfStudy=YearOfStudy.Others, ContactPhone=08665567, PreviouslyAccommodated = false},
            new Student{CAONumber = 3, LastName="Joe",FirstName="Jude",EMailAddress="ac@gmail.com", YearOfStudy=YearOfStudy.FinalYear, ContactPhone=089955567, PreviouslyAccommodated = false},
            new Student{CAONumber = 4, LastName="Thomas",FirstName="Navas",EMailAddress="bj@gmail.com", YearOfStudy=YearOfStudy.Others, ContactPhone=08665567, PreviouslyAccommodated = true},

            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var rooms = new List<Room>
            {
            new Room{RoomType=RoomType.EnsuiteSingle, QuantityAvailable=3, AmountDue=100.00}
            };

            rooms.ForEach(r => context.Rooms.Add(r));
            context.SaveChanges();

            var bookings = new List<Booking>
            {
            new Booking{StudentId = 1, DateOfApplication=DateTime.Parse("25.1.2017", new CultureInfo("fi-FI")), LastName="Carson",FirstName="Alexander",EMailAddress="ac@gmail.com", YearOfStudy=YearOfStudy.FirstYear, ContactPhone=089955567,PreviouslyAccommodated = false, RoomType=RoomType.EnsuiteSingle, RoomId=1, AmountDue=100.00, BookingStatus=BookingStatus.Confirmed },
            };

            bookings.ForEach(m => context.Bookings.Add(m));
            context.SaveChanges();


        }
    }
}