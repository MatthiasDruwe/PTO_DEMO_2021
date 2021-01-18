namespace Les_13
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Post
    {
        public int id { get; set; }

        public int author_id { get; set; }

        [Required]
        [StringLength(255)]
        public string title { get; set; }

        [Required]
        [StringLength(500)]
        public string description { get; set; }

        [Required]
        public string content { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        public virtual Author author { get; set; }

        public override string ToString()
        {
            return $"{title}";
        }
    }
}
