using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum_models.Models
{
    public class Forum
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime Created { get; set; }
        public string ImageUrl { get; set; } = null!;

        public IEnumerable<Post> Posts { get; set; }
    }
}
