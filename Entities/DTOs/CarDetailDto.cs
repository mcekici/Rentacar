using Core.Entities;
using Entities.Concrete;
using System.Collections.Generic;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        public CarDto Car { get; set; }
        public List<CarProperty> Properties { get; set; }

    }
}
