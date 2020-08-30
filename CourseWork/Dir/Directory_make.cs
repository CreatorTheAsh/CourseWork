using System;
using System.Collections.Generic;
using System.IO;
namespace Course_work
{
	class Directory_make
	{
		public static void Make()
		{
			try
			{
				Console.Write("Write path to Directory, like C:/Windows\n");
				string path = Console.ReadLine();
				if (Directory.Exists(path))
				{
					Console.WriteLine("Directory already exists\n");
				}
				else
				{
					List<string> parametrs = new List<string>();
					parametrs.Add("path=" + path);
					XMLLogWriter.XMLWriteLog("Directory_make", parametrs);
					Directory.CreateDirectory(path);
					Console.Write("Directory created successful\n");
				}
			}
			catch
			{
				List<string> parametrs = new List<string>();
				//parametrs.Add(pathfrom);
				//parametrs.Add(pathto);
				XMLLogWriter.XMLWriteError("Directory_make", parametrs);
				Console.WriteLine("Invalid data or unexisted directory");//выводим сообщение об ошибке
			}
		}
	}
}
