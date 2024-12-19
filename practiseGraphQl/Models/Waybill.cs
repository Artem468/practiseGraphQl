using System.ComponentModel.DataAnnotations;

namespace practiseGraphQl.Models
{
    public class Waybill
    {
        [Key] public long Id { get; set; }
        public DateTime Date { get; set; }
        public long ClientId { get; set; }
        public Client Client { get; set; }
        public long VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public long DriverId { get; set; }
        public Driver Driver { get; set; }
        public string RouteStart { get; set; }
        public string RouteEnd { get; set; }
        public decimal Distance { get; set; }
    }
}