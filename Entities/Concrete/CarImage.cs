using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class CarImage : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string Src { get; set; }
        public DateTime Date { get; set; }
        public bool IsMain { get; set; }
        public bool IsActive { get; set; }
    }
}
