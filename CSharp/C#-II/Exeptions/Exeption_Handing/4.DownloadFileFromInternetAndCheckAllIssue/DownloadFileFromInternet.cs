using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Data;
using System.IO;
using System.Threading;

namespace _4.DownloadFileFromInternetAndCheckAllIssue
{
    class DownloadFileFromInternet
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            try
            {
                client.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", Directory.GetCurrentDirectory()+"Logo-BASD.png");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The address can not be null");
            }
            catch (WebException)
            {
                Console.WriteLine("Invalid address or empty file.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("This method does not support simultaneous downloads.");
            }

            finally
            {
                client.Dispose();
            }
            
        }
    }
}
