using System.ComponentModel.DataAnnotations;

namespace UserExample
{
    internal class Car
    {
        public string Model { get; set; }
        public string Make { get; set; }
        [Key]
        public string ChassisNumber { get; set; }
        public User User { get; set; }
    }
}