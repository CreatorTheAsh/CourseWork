using System;
using System.IO;
using System.Collections.Generic;
namespace Course_work
{
    class File_move
    {

        public static void Move()
        {
            try
            {
                Console.Write("Write path to file, like C:/Windows/file1, where file1 is aim\n");
                string pathfrom = Console.ReadLine();
                Console.Write("Write path to new location, like C:/Users/file1\n");
                string pathto = Console.ReadLine();
                Console.WriteLine("path from: {0}", pathfrom);
                Console.WriteLine("path to: {0}", pathto);
                List<string> parametrs = new List<string>();
                parametrs.Add("pathfrom=" + pathfrom);
                parametrs.Add("pathto=" + pathto);
                XMLLogWriter.XMLWriteLog("File_move", parametrs);
                File.Move(pathfrom, pathto);
                Console.WriteLine("File moved successful");
            }
            catch
            {
                Console.WriteLine("Invalid data or unexisted file");//выводим сообщение об ошибке
                List<string> parametrs = new List<string>();
                //parametrs.Add(pathfrom);
                //parametrs.Add(pathto);
                XMLLogWriter.XMLWriteError("File_move", parametrs);
            }
        }
    }
}