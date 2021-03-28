using Core.Entities;

namespace Entities.Concrete
{
    public class Location : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string LatLong { get; set; }
    }
}
