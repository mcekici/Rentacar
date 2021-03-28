using Core.Entities;

namespace Entities.Concrete
{
    public class Property : IEntity
    {
        public int Id { get; set; }
        public int PropertyTypeId { get; set; }
        public string Value { get; set; }
    }
}
