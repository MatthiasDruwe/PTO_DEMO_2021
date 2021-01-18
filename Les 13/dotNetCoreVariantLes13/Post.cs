using System;
using System.Collections.Generic;

#nullable disable

namespace dotNetCoreVariantLes13
{
    public partial class Post
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public virtual Author Author { get; set; }
    }
}
