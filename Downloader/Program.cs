using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Downloader
{
    public class DownloaderURL
    {
        public bool Download(string pathTo, string URL)
        {
            try
            {
                WebClient currentClient = new WebClient();
                currentClient.DownloadFile(URL, pathTo);
                return true;
            }

            catch(ArgumentNullException)
            {
                Console.WriteLine("wrong URL. Check and try again.");
                return false;
            }

            catch (WebException)
            {
                Console.WriteLine("Some thing wrong with web connections. Try again.");
                return false;
            }

            catch (NotSupportedException)
            {
                Console.WriteLine("Some thing went wrong. Try again.");
                return false;
            }


        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            DownloaderURL currentDownloader = new DownloaderURL();

            bool success = false;

            Console.WriteLine("enter path where downloaded file will be saved, press enter and enter URL.");
            string path=Console.ReadLine();
            string URL = Console.ReadLine();

            while (success==false)
            {
                success=currentDownloader.Download(path, URL);
            }
        }
    }
}
