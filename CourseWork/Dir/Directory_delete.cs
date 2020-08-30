using System;
using System.IO;
using System.Collections.Generic;
namespace Course_work
{
	class Directory_delete
	{
		
		public static void Delete() 
		{
			try
			{
				Console.Write("Write path to Directory, like C:/Windows\n");
				string path = Console.ReadLine();
				if (Directory.Exists(path))
				{
					List<string> parametrs = new List<string>();
					parametrs.Add("path="+path);
					XMLLogWriter.XMLWriteLog("Directory_delete", parametrs);
					Directory.Delete(path);
					Console.Write("Directory deleted successful\n");
				}
				else
				{
					Console.WriteLine("Directory doesn't exists\n");
					//ToXML.ErrorLog("Directory doesn't exists");
				}
			}
			catch
			{
				Console.WriteLine("Invalid data or unexisted directory");//выводим сообщение об ошибке
				List<string> parametrs = new List<string>();
				//parametrs.Add(pathfrom);
				//parametrs.Add(pathto);
				XMLLogWriter.XMLWriteError("Directory_delete", parametrs);
			}
		}

	}
}
