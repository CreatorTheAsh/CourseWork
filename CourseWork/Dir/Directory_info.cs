using System;
using System.IO;
using System.Collections.Generic;
namespace Course_work
{
    class Directory_info
    {
        public static void Search()
        {
            try
            {
                Console.Write("Write path, like C:/Windows\n");//приводим пример
                string path = Console.ReadLine();//получаем строку от пользователя
                Console.WriteLine("path is: {0}", path);//показываем то что пользователь ввел
                List<string> parametrs = new List<string>();
                parametrs.Add("path=" + path);
                XMLLogWriter.XMLWriteLog("Directory_info", parametrs);
                DirectoryInfo chooseddir = new DirectoryInfo(path);
                DirectoryInfo[] listofdirs = chooseddir.GetDirectories();
                FileInfo[] listoffiles = chooseddir.GetFiles();
                //Console.WriteLine(chooseddir);
                foreach (DirectoryInfo l1 in listofdirs)//перебираем директории 1-го уровня
                {
                    Console.WriteLine("\t" + l1.FullName);//выводим директорию 1-го уровня
                    DirectoryInfo[] l1_listofdirs = l1.GetDirectories();//директории 2-го уровня
                    FileInfo[] l1_listoffiles = l1.GetFiles();//файлы 2-го уровня
                    foreach (DirectoryInfo l2 in l1_listofdirs)//перебираем директории 2-го уровня
                    {
                        Console.WriteLine("\t\t" + l2.FullName);//выводим директорию 2-го уровня
                        FileSystemInfo[] innerobjs = l2.GetFileSystemInfos();// получаем содержимое 3-го уровня
                        foreach (FileSystemInfo innerobj in innerobjs)
                        {
                            Console.WriteLine("\t\t\t" + innerobj.FullName);//выводим содержимое 3-го уровня на экран
                        }
                    }
                    foreach (FileInfo f in l1_listoffiles)
                    {
                        Console.WriteLine("\t\t" + f.FullName);//выводим файлы 2-го уровня на экран
                    }

                }
                foreach (FileInfo f in listoffiles)
                {
                    Console.WriteLine("\t" + f.FullName);//выводим файлы 1-го уровня на экран
                }
            }
            catch
            {
                Console.WriteLine("Invalid data or unexisted directory");//выводим сообщение об ошибке
                List<string> parametrs = new List<string>();
                //parametrs.Add(pathfrom);
                //parametrs.Add(pathto);
                XMLLogWriter.XMLWriteError("Directory_info", parametrs);
            }
        }
    }
}
