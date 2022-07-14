using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // This Namespace is used for performing operations with files
namespace File_IO
{
    public class FileStreamclass
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\NITISH MEHTA\OneDrive\Desktop\Bridge_Labz\27\Dispaly.txt";

            //  The FileStream is a class used for reading and writing files in C#.
            //  It is part of the System.IO namespace.
            //  FileStream file = new FileStream(path, FileMode.Create); //FileMode.Create - to create file

            // if u don't want to give File.close method then by using Block we programer can close open the file
            //  using (FileStream file = new FileStream(path, FileMode.Create))

            using (FileStream file = new FileStream(path, FileMode.Create,FileAccess.Write)) //FileAccess.Write - to write in file
            {
                file.WriteByte(78); // N ascii code Table
                Console.WriteLine("File Created");
            }

           //  file.Close(); // To Close the open file & if you don't 
            Console.ReadLine();
        }
    }
}
