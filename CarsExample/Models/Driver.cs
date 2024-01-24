namespace CarsExample.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Car>? Cars { get; set; }
    }
}