using System;
using System.IO;
using System.Collections.Generic;
namespace Course_work
{
    class File_rename
    {
        
        public static void Rename() 
        {
            try
            {
				Console.Write("Write path to file, like C:/Windows\n");
				string path = Console.ReadLine();
				Console.Write("Write new name, like Users\n");
				string name = Console.ReadLine();
				string[] newpath_name;
				if (name.Contains("/"))
				{
					newpath_name = path.Split('/');
					newpath_name[^1] = name;
					name = "";
					for (int i = 0; i < newpath_name.Length; i++)
					{
						name = name + newpath_name[i] + "\\";
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
						name = name + newpath_name[i] + "\\";
					}
					name = name.Remove(name.Length - 1);
					//name = name.Substring(name.Length - 2);
				}
				//FileInfo f = new FileInfo(path);
				List<string> parametrs = new List<string>();
				parametrs.Add("path=" + path);
				parametrs.Add("name=" + name);
				XMLLogWriter.XMLWriteLog("File_rename", parametrs);
				File.Move(path, name);
				Console.WriteLine("File renamed successful");
			}
            catch
            {
                Console.WriteLine("Invalid data or unexisted file");//выводим сообщение об ошибке
				List<string> parametrs = new List<string>();
				//parametrs.Add(pathfrom);
				//parametrs.Add(pathto);
				XMLLogWriter.XMLWriteError("File_rename", parametrs);
			}
        }

    }
}
