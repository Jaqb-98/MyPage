using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPage.Models
{
    public class RssItems
    {
        public RssItem Item { get; set; }
    }

    public class RssItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string PubDate { get; set; }
    }
}
