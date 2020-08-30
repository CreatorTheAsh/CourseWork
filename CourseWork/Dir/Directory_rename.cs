using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace Course_work
{
	class Directory_rename
	{
		
		public static void Rename() 
		{
			try
			{
				Console.Write("Write path to Directory, like C:/Windows\n");
				string path = Console.ReadLine();
				Console.Write("Write new name, like Users\n");
				string name = Console.ReadLine();
				List<string> parametrs = new List<string>();
				parametrs.Add("path=" + path);
				parametrs.Add("name=" + name);
				XMLLogWriter.XMLWriteLog("Directory_rename", parametrs);
				string[] newpath_name;
				if (name.Contains("/"))
				{
					newpath_name = path.Split('/');
					newpath_name[^1] = name;
					name = "";
					for (int i = 0; i < newpath_name.Length; i++)
					{
						name = name + newpath_name[i]+"\\";
					}
					name = name.Remove(name.Length - 1);
				}
				else
				{
					newpath_name = path.Split('\\');
					newpath_name[^1] = name;
					name = "";
					for (int i = 0; i < newpath_name.Length; i++)
					{
						name = name + newpath_name[i]+"\\";
					}
					name = name.Remove(name.Length - 1);
				}

					//DirectoryInfo d = new DirectoryInfo(path);
					Directory.Move(path,name);
				//FileSystem.Rename(String, String)
				Console.WriteLine("Directory renamed successful");

			}
			catch
			{
				Console.WriteLine("Invalid data or unexisted directory");//выводим сообщение об ошибке
				List<string> parametrs = new List<string>();
				//parametrs.Add(pathfrom);
				//parametrs.Add(pathto);
				XMLLogWriter.XMLWriteError("Directory_rename", parametrs);
			}
		}

	}
}
