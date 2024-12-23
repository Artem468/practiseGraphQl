using System.ComponentModel.DataAnnotations;

namespace practiseGraphQl.Models
{
    public class Vehicle
    {
        [Key] public long Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Capacity { get; set; }
        public string LicensePlate { get; set; }
        
        public int FuelRate { get; set; }
        public ICollection<Waybill>? Waybills { get; set; }
    }
}