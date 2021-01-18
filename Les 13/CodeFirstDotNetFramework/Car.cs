using System.ComponentModel.DataAnnotations;

namespace CodeFirstDotNetFramework
{
    class Car
    {
        private int id;
        private string model;
        private string color;
        private User user;

        [Key]
        public int Id { get => id; set => id = value; }
        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public User User { get => user; set => user = value; }
    }
}
