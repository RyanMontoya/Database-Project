// See https://aka.ms/new-console-template for more information


using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Text.Encodings.Web;

class program {


  

    static void Main(String[] args)
    {

        program p = new program();
        string tmp = p.database(); 
        Console.WriteLine("Hello, World!"+p);
        Console.WriteLine("enter url request:");
        string url = Console.ReadLine();
        string html = string.Empty;



        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        request.AutomaticDecompression = DecompressionMethods.GZip;

        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        using (Stream stream = response.GetResponseStream())
        using (StreamReader reader = new StreamReader(stream))
        {
            html = reader.ReadToEnd();
        }

 

    } 

    public String database()
    {
        return "database";
    }





   }