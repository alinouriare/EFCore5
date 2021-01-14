using System.Collections.Generic;

namespace NetFive
{
    public class Tag
    {
        public int TagId { get; set; }

        public string Name { get; set; }

        public List<News>   News { get; set; }
    }
}