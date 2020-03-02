using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HtmlAgilityPack;
using Project_Sem_3_Crawl.Models;

namespace Project_Sem_3_Crawl.Controllers
{
    public class SourcesController : Controller
    {
        private MyConnection db = new MyConnection();

        // GET: Sources
        public ActionResult Index()
        {
            var url = "https://vnexpress.net/the-gioi";
            var web = new HtmlWeb();
            var htmlDoc = web.Load(url);
            var threadItems = htmlDoc.DocumentNode.SelectNodes("//article[contains(@class,'list_news')]/h4").ToList();

            var items = new List<object>();
            foreach (var item in threadItems)
            {
                var linkNode = item.SelectSingleNode(".//a");
                var link = linkNode.Attributes["href"].Value;
                //var text = linkNode.InnerText;
                //var readCount = item.SelectSingleNode(".//div[@class='folTypPost']/ul/li/b").InnerText;

                Source source = new Source()
                {
                    Link = link
                };
                items.Add(source);
                //items.Add(new
                //{
                //    link
                //});
                Console.WriteLine(items);
            }

            return View(db.Sources.ToList());
        }
    }
}
