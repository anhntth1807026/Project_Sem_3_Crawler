using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project_Sem_3_Crawl.Models
{
    public class Source 
    {
        [Key] public string SourceId { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        

    }
}