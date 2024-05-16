using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reddit.Library.SearchFunctions
{
    public static class Search
    {
        public static string StringToQuery(string Query)
        {
            // Seperate words by +
            Query = Query.Replace(" ", "+");
            return Query;
        }

        public static string SearchQuery(string Query) { 

            HtmlWeb web = new HtmlWeb();


            HtmlDocument doc = web.Load($"https://search.brave.com/search?q={Query}+reddit&source=web");

            //Select a specific node from the HTML doc

            var Headers = doc.DocumentNode.CssSelect("a");

            //Extract the text and store it in a CSV file

            string result = "";

            foreach (var item in Headers)
            {
                var Href = item.Attributes["href"].Value;
                if (Href.Contains("http") && Href.Contains("reddit"))
                {
                    Console.WriteLine(Href);
                    result += Href + "\n";
                }
            }
            return result;
        }

    }
}
