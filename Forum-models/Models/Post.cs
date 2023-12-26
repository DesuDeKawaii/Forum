using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum_models.Models
{
    public class Post
    {
        public int Id { get; set; } 
        public DateTime Created { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public bool IsArchived { get; set; }


        public virtual User User { get; set; }
        public virtual IEnumerable<PostReply> Replies { get; set; }
        public virtual Forum Forum { get; set; }
    }
}
