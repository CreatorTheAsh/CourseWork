using System;
using System.IO;
using System.Collections.Generic;
namespace Course_work
{
    class Directory_move
    {

        public static void Move()
        {
            try
            {
                Console.Write("Write path to Directory, like C:/Windows/dir1, where dir1 is aim\n");
                string pathfrom = Console.ReadLine();
                Console.Write("Write path to new location, like C:/Users/dir1\n");
                string pathto = Console.ReadLine();
                Console.WriteLine("path from: {0}", pathfrom);
                Console.WriteLine("path to: {0}", pathto);
                List<string> parametrs = new List<string>();
                parametrs.Add("pathto=" + pathfrom);
                parametrs.Add("pathto=" + pathto);
                XMLLogWriter.XMLWriteLog("Directory_move", parametrs);
                Directory.Move(pathfrom, pathto);
                Console.WriteLine("Directory moved successful");
            }
            catch
            {
                Console.WriteLine("Invalid data or unexisted directory");//выводим сообщение об ошибке
                List<string> parametrs = new List<string>();
                //parametrs.Add(pathfrom);
                //parametrs.Add(pathto);
                XMLLogWriter.XMLWriteError("Directory_move", parametrs);
            }
        }
    }
}