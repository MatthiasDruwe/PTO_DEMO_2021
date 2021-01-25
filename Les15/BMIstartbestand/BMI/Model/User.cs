using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMI.Model
{
    class User
    {
        DateTime birthdate;
        public User() { }

        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime BirthDate
        {
            get => birthdate; 
            set
            {
                if(value.AddYears(18) > DateTime.Today)
                {
                    throw new FormatException("Too Young");
                }
                birthdate = value;
            }
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
