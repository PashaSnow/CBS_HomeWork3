using System;
using System.IO;

namespace AdditionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(".");
            directory.CreateSubdirectory(@"Folders\");
            string path = @"Folders\";
            for (int i = 0; i < 100; i++)
            {
                directory.CreateSubdirectory(Path.Combine(path, $"Folder_{i:##.#}"));
            }
            Console.WriteLine(path);
            Console.WriteLine("All folders created");
            Console.WriteLine("Press any kye for deleted folders");
            Console.ReadKey();

            DirectoryInfo[] directories = directory.GetDirectories(path);
            Console.WriteLine(Environment.NewLine + $"This directory have {directories.Length + 1} folders");
            foreach (DirectoryInfo folder in directories)
            {
                folder.Delete();
            }

            Console.ReadKey();
        }
    }
}
