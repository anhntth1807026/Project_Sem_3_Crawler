using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Sem_3_Crawl.Models
{
    public class Article
    {
        public string Link { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
    }
}