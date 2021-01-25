using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMI.Model
{
    class Bmi
    {

        public Bmi()
        {
           
        }

        public Bmi(DateTime date, double weight, double height, int userId)
        {
            Date = date;
            Weight = weight;
            Height = height;
            UserId = userId;
        }


        public DateTime Date { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        public double Weight { get; set; }
        [Required]
        public double Height { get; set; }

        [NotMapped]
        public double BMI
        {
            get { return Weight / (Height * Height); }
        }

        // BMI = gewicht / lengte²


        public override string ToString()
        {
            return $"{Date} => {BMI}"; 
        }
    }
}
