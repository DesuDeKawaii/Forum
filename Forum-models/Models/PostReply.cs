using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum_models.Models
{
    public class PostReply
    {
        public int Id { get; set; }
        public string Content { get; set; } = null!;
        public DateTime Created { get; set; }


        public virtual User User { get; set; }
        public virtual Post Post { get; set; }
    }
}
