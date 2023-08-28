using System;
using System.Collections.Generic;

namespace BlogPlatformMvc.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Author { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
