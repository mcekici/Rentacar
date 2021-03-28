using Core.Entities;

namespace Entities.Concrete
{
    public class Serial : IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string SerialName { get; set; }
    }

}
