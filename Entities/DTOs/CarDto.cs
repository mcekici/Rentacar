using Core.Entities;
using System;
using System.Text;

namespace Entities.DTOs
{
    public class CarDto : IDto
    {
        public int Id { get; set; }
        public string Plate { get; set; }
        public string Name { get; set; }
        public int ModelYear { get; set; }
        public string Class { get; set; }
        public decimal DailyPrice { get; set; }
        public decimal DepositFee { get; set; }
    }
}
