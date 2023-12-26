using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum_models.Models
{
    public class ForumListeningModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfPosts { get; set; }
        public int NumberOfUsers { get; set; }
        public string ImageUrl { get; set; }
        public bool HasRecentPost { get; set; }

        public PostListeningModel Latest { get; set; }
        public IEnumerable<PostListeningModel> AllPosts { get; set; }
    }
}
