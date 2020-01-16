using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Crawler
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create("http://www.pja.edu.pl/");
            myRequest.Method = "GET";
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            string result = sr.ReadToEnd();
            sr.Close();
            myResponse.Close();

            HtmlDocument page = new HtmlDocument();
            page.LoadHtml(result);

            var textDescription = page.ParsedText;
            //Napiszcie crawler, który wyciągnie z tekstu wszystkie numery telefonów. Spróbujcie skorzystać
            //z wyrażeń regularnych.
            //https://regex101.com/
            //Możecie skorzystać z powyższej strony, żeby sprawdzić jakie wyrażenie regularne zadziała poprawnie.
            Regex regex = new Regex(textDescription);
            regex.Matches("((\\+)?48)?[ ]?\\d+[ ]?\\d+[ ]?\\d+[ ]?\\d+");
        }
    }
}
