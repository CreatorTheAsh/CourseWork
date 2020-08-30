using System;
using System.IO;
using System.Collections.Generic;
namespace Course_work
{
    static class File_make
    {
        public static void Make()
        {
			try
			{
				Console.Write("Write path to file, like C:/Windows\n");
				string path = Console.ReadLine();
				if (File.Exists(path))
				{
					Console.WriteLine("File already exists\n");
				}
				else
				{
					List<string> parametrs = new List<string>();
					parametrs.Add("path=" + path);
					XMLLogWriter.XMLWriteLog("File_make", parametrs);
					//File.Create(path);
					using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
					{
						sw.WriteLine("");
					}
					Console.Write("File created successful\n");
				}
			}
			catch
			{
				Console.WriteLine("Invalid data or unexisted file");//выводим сообщение об ошибке
				List<string> parametrs = new List<string>();
				//parametrs.Add(pathfrom);
				//parametrs.Add(pathto);
				XMLLogWriter.XMLWriteError("File_make", parametrs);
			}
		}
    }
}
