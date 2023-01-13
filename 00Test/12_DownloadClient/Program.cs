using _12_DownloadClient;

List<Uri> uris = new List<Uri>();
uris.Add(new Uri("http://bit.ly/leseprobe_schroedinger_cplusplus"));
uris.Add(new Uri("http://bit.ly/leseprobe_schroedinger_abap"));
uris.Add(new Uri("http://bit.ly/leseprobe_schroedinger_html5"));
uris.Add(new Uri("http://bit.ly/leseprobe_programmieren_lernen"));
uris.Add(new Uri("https://www.thecodingguys.net/resources/cs-cheat-sheet.pdf"));

List<Task<string>> tasks = new List<Task<string>>();
foreach (var url in uris)
{
    PdfDownloader downloader = new PdfDownloader();
    Task<string> t = downloader.DownloadAsync(url);
    string r =t.Result;
    tasks.Add(t);
    Console.WriteLine(r);

}
Task.WaitAll(tasks.ToArray());
//Warten bis alle task fertig sind 
Console.WriteLine("Alle programme abgeschloßen");

Console.ReadLine();