using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPage.Models
{
    public class PageModel
    {
        public PhotoData[] PhotoData { get; set; }
        public List<RssItem> RssItems { get; set; }

        public PageModel()
        {

        }
    }
}
