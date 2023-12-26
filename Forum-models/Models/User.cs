using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum_models.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public int Rating { get; set; }
        public bool IsActive { get; set; }
        public string UserDescription { get; set; } = null!;
        public string ProfileImageUrl { get; set; } = null!;
        public bool IsAdmin { get; set; }
        public DateTime MemberSince { get; set; }

        public virtual ICollection<Post> Posts { get; set;}
        public virtual ICollection<PostReply> PostReplies { get; set; }
    }
}
