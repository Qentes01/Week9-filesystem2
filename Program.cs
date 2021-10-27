using System;
using System.IO;

namespace FileCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples\wishlist";
            Console.WriteLine("Enter file name:");
            string filename = Console.ReadLine(); ;
            string fullfilePath = $@"{rootDirectory}\{filename}.txt";

            bool directoryExists = Directory.Exists(rootDirectory);
            bool fileExists = File.Exists(fullfilePath);

            if(directoryExists && fileExists)
            {
                Console.WriteLine($"File  {filename} already exists in {rootDirectory}.");
            }
            else if (!directoryExists)
            {
                Console.WriteLine($"wishlist directory does not exist.");
                Directory.CreateDirectory(rootDirectory);
                File.Create(fullfilePath);
                Console.WriteLine($"File {filename}.txt has been created.");



                File.Create(rootDirectory);
            }
            else
            {
                File.Create(fullfilePath);
                Console.WriteLine($"File {filename}.txt has been created");
            }

            
            
        }
    }
}
