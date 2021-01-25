using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMI.Model
{
    class User
    {
        public User() { }

        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
