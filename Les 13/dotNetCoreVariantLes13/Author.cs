using System;
using System.Collections.Generic;

#nullable disable

namespace dotNetCoreVariantLes13
{
    public partial class Author
    {
        public Author()
        {
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime Added { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
