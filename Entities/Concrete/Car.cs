using Core.Entities;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public int SerialId { get; set; }
        public string Name { get; set; }
        public int ModelYear { get; set; }
        public string Plate { get; set; }
        public decimal DailyPrice { get; set; }
        public decimal DepositFee { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

    }
}
