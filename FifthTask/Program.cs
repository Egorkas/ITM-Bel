using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.OutputEncoding = System.Text.Encoding.UTF8;
        TransformToElephant();
        Console.WriteLine("Муха");
        //... custom application code

        var a = 5;
        var result = Console.ReadLine();
        if (result == "a")
        {
            a = 7;
        }
    }
    static void TransformToElephant()
    {
        Console.WriteLine("Слон");
        Console.SetOut(TextWriter.Null);
    }
} 