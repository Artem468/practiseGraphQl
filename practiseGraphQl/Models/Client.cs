using System.ComponentModel.DataAnnotations;

namespace practiseGraphQl.Models
{
    public class Client
    {
        [Key] public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public ICollection<Waybill>? Waybills { get; set; }
    }
}