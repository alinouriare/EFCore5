using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFive
{
   public class News
    {
        public int NewsId { get; set; }

        public string Title { get; set; }

       public string Body { get; set; }

        public List<Tag>  Tags { get; set; }
    }
}
