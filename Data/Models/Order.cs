using API.Data.Models.Base;

namespace API.Data.Models
{
    public class Order : EntityBase
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
    }
}