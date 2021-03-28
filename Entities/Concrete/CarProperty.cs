using Core.Entities;

namespace Entities.Concrete
{
    public class CarProperty : IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int PropertyId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
    }
}
