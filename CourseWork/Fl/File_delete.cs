using System;
using System.IO;
using System.Collections.Generic;
namespace Course_work
{
    static class File_delete
    {
        public static void Delete() 
        {
			try
			{
				Console.Write("Write path to file, like C:/Windows\n");
				string path = Console.ReadLine();
				if (File.Exists(path))
				{

					List<string> parametrs = new List<string>();
					parametrs.Add("path=" + path);
					XMLLogWriter.XMLWriteLog("File_delete", parametrs);
					File.Delete(path);
					Console.Write("File deleted successful\n");
				}
				else
				{
					Console.WriteLine("File doesn't exists\n");
				}
			}
			catch
			{
				Console.WriteLine("Invalid data or unexisted file");//выводим сообщение об ошибке
				List<string> parametrs = new List<string>();
				//parametrs.Add(pathfrom);
				//parametrs.Add(pathto);
				XMLLogWriter.XMLWriteError("File_delete", parametrs);
			}//C:/Users/Aleksandr/Desktop/summerWork/fatWork
		}

    }
}
