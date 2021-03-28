using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Rental : IEntity
    {
        public int Id { get; set; }
        public int ReservationId { get; set; }
        public int UserId { get; set; }
        public string UserFullName { get; set; }
        public int CarId { get; set; }
        public DateTime RentDate { get; set; }
        public int RentLocationId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int ReturnLocationId { get; set; }
        public decimal TotalFee { get; set; }
    }

}
