    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO; // This Namespace is used for performing operations with files
    namespace File_IO
    {
        public class DirectoryInfoClass
        {
            public static void Main(string[] args)
        {
             string path = @"C:\Users\NITISH MEHTA\OneDrive\Desktop\Bridge_Labz\27/My Directory2";
             string path2 = @"C:\Users\NITISH MEHTA\OneDrive\Desktop\Bridge_Labz\27/My Directory";
             string path3 = @"C:\Users\NITISH MEHTA\OneDrive\Desktop\Bridge_Labz\27/new\new1";
             DirectoryInfo dir = new DirectoryInfo(path3);
             Console.WriteLine(dir.Name); 
             Console.WriteLine(dir.FullName);
             Console.WriteLine(dir.LastAccessTime);
             Console.WriteLine(dir.CreationTime);
             Console.WriteLine(dir.Parent);
             Console.WriteLine(dir.Attributes);
             Console.WriteLine(dir.Root);
             Console.WriteLine(dir.LastAccessTime);


            // DirectoryInfo[] dirs = dir.GetDirectories(); // it show the directory path
            // foreach (var iteam in dirs)
            // {
            //    //Console.WriteLine(iteam.FullName);
            //    Console.WriteLine(iteam.GetFiles().Length);
            // }
            // dir.Delete(true);
            // Console.WriteLine("Directory Deleted");
            // dir.MoveTo(path2);
            // Console.WriteLine("Directory Moved");

            // dir.Create();       // To create new directory
            // dir.CreateSubdirectory("New Directory");  // To Create SubDirectory
            //   Console.WriteLine("New Directory Created");


            Console.ReadLine();
            }
        }
    }
