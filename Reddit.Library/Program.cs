//Dependencies of the project
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace Reddit.Library
{
    // Console App - Lacks Functionality Of Web App
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Question");
            var q = SearchFunctions.Search.StringToQuery(Console.ReadLine());
            SearchFunctions.Search.SearchQuery(q);
        }
    }
}


