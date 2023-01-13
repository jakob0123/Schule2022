using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _12_DownloadClient
{
    internal class PdfDownloader
    {
        public async Task<string>DownloadAsync(Uri url)
        {
            #region webclient
            using (WebClient client = new WebClient())
            {
                string pdfname;
                if (!url.Segments.Last().EndsWith("pdf"))
                {
                    pdfname = url.Segments.Last()+".pdf";
                }
                else
                {
                    pdfname = url.Segments.Last();
                }
                string filename = @"C:\dev\" + pdfname;
                Console.Write("Download:" + pdfname + "::::::::::::::::::");
                Task t = client.DownloadFileTaskAsync(url, filename);
                await t;
                Console.WriteLine("Download finished: "+pdfname);
                //hier wird automatisch ein Task Objekt zurückgeben(macht Compiler)
                return filename;
            }
            #endregion
        }
    }
}
