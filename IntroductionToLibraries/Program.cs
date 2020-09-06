using System;
using System.ComponentModel;
using System.IO;
using static MathematicalOperations.Operations;
using static System.Console;

namespace IntroductionToLibraries
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteLine("Enter first value:");
            //int a = Convert.ToInt32(Console.ReadLine());

            //WriteLine("Enter Second value:");
            //int b = Convert.ToInt32(Console.ReadLine());

            //WriteLine($"The output of the given value is : {Add(a,b)}");

            ////Files
            //DirectoryInfo dirInfo = new DirectoryInfo("C:\\Users\\gauravr\\Documents\\TestFolder");
            //DirectoryInfo [] folders = dirInfo.GetDirectories();

            //foreach (var item in folders)
            //{
            //    WriteLine(item.Name);
            //    WriteLine("------------------------");
            //    foreach(var file in item.GetFiles())
            //    {
            //        WriteLine(file.Length); //size of files
            //    }
            //}

            WriteLine("Enter the Directory Path");
            string path = Console.ReadLine();

            //Files
            DirectoryInfo dirInfo1 = new DirectoryInfo(path);
            bool value = dirInfo1.Exists;
            if (value.Equals(true))
            {
                DirectoryInfo[] folder = dirInfo1.GetDirectories();

                foreach (var item in folder)
                {
                    WriteLine(item.Name);
                    WriteLine("------------------------");
                    foreach (var file in item.GetFiles())
                    {
                        WriteLine(file.Length); //size of files
                    }
                }
            }
            else
            {
                WriteLine("Incorrect Path");
            }
            ReadLine();
        }
    }
}