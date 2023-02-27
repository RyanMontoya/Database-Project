// See https://aka.ms/new-console-template for more information


using System.ComponentModel.DataAnnotations.Schema;

class program {

    static void Main(String[] args)
    {

        program p = new program();
        String tmp = p.database(); 
        Console.WriteLine("Hello, World!"+p);


    } 

    public String database()
    {
        return "database";
    }


   }