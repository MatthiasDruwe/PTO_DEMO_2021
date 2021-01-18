using System.ComponentModel.DataAnnotations;

namespace CodeFirstDotNetCore
{
    class User
    {
        private int id;
        private string firstName;
        private string lastName;

        [Key]
        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
    }
}
