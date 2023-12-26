using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum_models.Models
{
    public class ForumIndexModel
    {
        public int NumberOfForums { get; set; }

        public IEnumerable<ForumListeningModel> ForumList { get; set; }
    }
}
