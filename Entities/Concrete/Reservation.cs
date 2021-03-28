using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Reservation : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserFullName { get; set; }
        public int CarId { get; set; }
        public DateTime ProcessDate { get; set; }
        public DateTime RentDate { get; set; }
        public int RentLocationId { get; set; }
        public DateTime ReturnDate { get; set; }
        public int ReturnLocationId { get; set; }
        public int StatusId { get; set; }
    }

}
