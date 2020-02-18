using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"text.txt";
            FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine("Pavel Bauman is cool .Net Developer)");

            Console.WriteLine("File created");
            Console.WriteLine($"Press any key to read conten - {File.Exists(path)}");


            StreamReader reader = new StreamReader(file);
            Console.WriteLine(reader.ReadToEnd());
            writer.Close();
            reader.Close();


            Console.ReadKey();
        }
    }
}
