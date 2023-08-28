using BlogPlatformMvc.Models;
using System;

namespace BlogPlatform.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime PublicationDate { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
