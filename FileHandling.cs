using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // This Namespace is used for performing operations with files
namespace File_IO
{
    public class FileHandling
    {
       public static void Main(string[] args)
        {
            string path = @"C:\Users\NITISH MEHTA\OneDrive\Desktop\Bridge_Labz\27\File_IO\File_IO\Program.cs";

            //(.Exists)_Method checking whether the specified path Exists or not- gives boolen values
            if (File.Exists(path))
            {
                Console.WriteLine("Yes, the file exists");
            }
            else
            {
                Console.WriteLine("No, the file don't exists");
            }
            Console.ReadLine();
       }
    }
}
