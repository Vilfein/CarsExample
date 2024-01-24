namespace CarsExample.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public int? DriverId { get; set; }
        public Driver? Driver { get; set; }
    }
}
