using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AccommodationWebApp.Models;

namespace AccommodationWebApp.DAL
{
    public class AccommodationInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AccommodationContext>
    {
        protected override void Seed(AccommodationContext context)
        {
            var dbcontext = new AccommodationContext();

            var students = new List<Student>
            {
            new Student{CAONumber = 1, LastName="Carson", FirstName="Alexander", EMailAddress="ac@gmail.com", YearOfStudy=YearOfStudy.FirstYear, ContactPhone=089955567, PreviouslyAccommodated=false },
            new Student{CAONumber = 2, LastName="Billy", FirstName="James", EMailAddress="bj@gmail.com", YearOfStudy=YearOfStudy.Others, ContactPhone=08665567, PreviouslyAccommodated=true},
            };
            students.ForEach(s => context.Students.Add(s));
            dbcontext.SaveChanges();

            var bookings = new List<Booking>
            {
            new Booking{DateOfApplication=DateTime.Now, RoomType=Rooms.EnsuiteSingle, AmountDue=100}
            };

            bookings.ForEach(b => context.Bookings.Add(b));
            dbcontext.SaveChanges();

            var rooms = new List<Room>
            {
            new Room{RoomType=RoomType.EnsuiteSingle, QuantityAvailable=3, RoomStatus=RoomStatus.Occupied, AmountDue=100.00}
            };

            rooms.ForEach(r => context.Rooms.Add(r));
            context.SaveChanges();

            //var myApplications = new List<MyApplication>
            //{
            //new MyApplication{StudentId = 1, RoomType= Rooms.EnsuiteSingle, AdmountDue=100.00, DateOfApplication=DateTime.Parse("25-01-2017") },
            //};

            //myApplications.ForEach(m => context.MyApplications.Add(m));
            //context.SaveChanges();
        }
    }
}