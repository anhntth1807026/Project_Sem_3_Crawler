using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;

namespace Project_Sem_3_Crawl.Models
{
    public class Crawl
    {
        //public string Title { get; set; }
        //public string Link { get; set; }
        //public string Description { get; set; }
    }
}


//public static void Main()
//{
//    var html = new HtmlWeb();
//    var document = html.Load("https://vnexpress.net/");
//    var items = new List<object>();
//    var threadItems = document.DocumentNode.QuerySelectorAll("article").ToList();
//    foreach (var item in threadItems)
//    {
//        var title = item.QuerySelector("h4").InnerText;
//        var link = item.QuerySelector("a").Attributes["href"].Value;
//        items.Add(new
//        {
//            title,
//            link
//        });
//        Console.WriteLine(item.InnerText);
//    }

//    //HtmlWeb web = new HtmlWeb();
//    //HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
//    //doc = web.Load("https://en.wikipedia.org/wiki/Main_Page");

//    //// filter html elements on the basis of class name
//    //IEnumerable<HtmlNode> nodes = doc.DocumentNode.Descendants().Where(n => n.HasClass("mw-jump-link"));

//    //foreach(var item in nodes)
//    //{
//    //	// displaying final output
//    //	Console.WriteLine(item.InnerText);	
//    //}
//}