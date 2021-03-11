using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPage.Models
{
    public class PhotoData
    {
        public Urls Urls { get; set; }
    }


    public class Urls
    {
        public string raw { get; set; }
        public string full { get; set; }
        public string regular { get; set; }
        public string small { get; set; }
        public string thumb { get; set; }
    }

}


























