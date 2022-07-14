using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // This Namespace is used for performing operations with files
namespace File_IO
{
    public class ReadingDataFromTextFile
    {
        public static void Main(string[] args)
        {
            //@-In C#, a verbatim string is created using a special symbol @.
            //@ is known as a verbatim identifier.
            string path = @"C:\Users\NITISH MEHTA\OneDrive\Desktop\Bridge_Labz\27\FileIO.txt";

            //(File.Exists)- method is used to check that a particular file exists or not.
            if (File.Exists(path))
            {
                Console.WriteLine("Yes, the file exists");

                //ReadAllText(String) is used for Opens a text file, reads all the text in the file,
                //and then closes the file.
                string data = File.ReadAllText(path);
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("No, the file don't exists");
            }
            Console.ReadLine();
        }
    }

}

