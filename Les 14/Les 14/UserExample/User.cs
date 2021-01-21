using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserExample
{
    internal class User
    {
        public User()
        {
            Cars = new List<Car>();
        }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public List<Car> Cars { get; set; }

        [NotMapped]
        public string FullName { get => $"{FirstName} {LastName}"; }

        [NotMapped]
        public int Age { 
            get {
                return 5;
            }
        }
    }
}