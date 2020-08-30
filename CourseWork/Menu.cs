using System;
using System.Collections.Generic;
using System.Xml;
namespace Course_work
{
	class Menu
	{
		
		public void Help()
		{
			//Console.WriteLine("write number of command");
			Console.Write("Commands:\n");
			Console.Write("[1]-\tsearch directory \n");
			Console.Write("[2]-\tmake directory \n");
			Console.Write("[3]-\tdelete directory \n");
			Console.Write("[4]-\tmove directory\n");
			Console.Write("[5]-\trename directory\n");

			Console.Write("[6]-\tsearch file \n");
			Console.Write("[7]-\tmake file \n");
			Console.Write("[8]-\tdelete file \n");
			Console.Write("[9]-\tmove file\n");
			Console.Write("[10]-\trename file\n");

			Console.Write("[11]-\tshow help\n");
			Console.Write("[12]-\texit\n");
		}
		public void Comand_choose()
		{
			XMLLogWriter.XMLCreateRoot();
			Help();
			List<string> parametrs = new List<string>();
			DateTime dateStart = new DateTime();
			dateStart = DateTime.Now;
			parametrs.Add("Time="+dateStart.ToString());
			XMLLogWriter.XMLWriteLog("Start", parametrs);
			bool KeepWork=true;
			while(KeepWork)
			{
				Console.WriteLine("write number of command");
				string line = Console.ReadLine();
                int.TryParse(line, out int command_number);
                switch (command_number)
				{
					//dir
					case 1:
						Console.WriteLine("Choosed Search");
						Directory_info.Search();
						//Do it!
						break;
					case 2:
						Console.Write("make directory\n");

						Directory_make.Make();
						//Do it!
						break;
					case 3:
						Console.Write("delete directory\n");
						Directory_delete.Delete();
						//Do it!
						break;
					//file
					case 4:
						Console.Write("move directory\n");
						Directory_move.Move();
						//Do it!
						break;
					case 5:
						Console.Write("rename directory\n");
						Directory_rename.Rename();
						//Do it!
						break;
					case 6:
						Console.Write("search file\n");
						File_info.Info();
						//Do it!
						break;
					//fffffff
					case 7:
						 Console.Write("make file");
						File_make.Make();
						//Do it!
						break;
					case 8:
						Console.Write("delete file\n");
						File_delete.Delete();
						//Do it!
						break;

					case 9:
						Console.Write("move file\n");
						File_move.Move();
						//Do it!
						break;
					case 10:
						Console.Write("rename file\n");
						File_rename.Rename();
						//Do it!
						break;
					//help & exit
					case 11:
						//Console.Write("show help\n");
						Help();
						//Do it!
						break;
					case 12:
						Console.Write("exit\n");
						DateTime dateEnd = new DateTime();
						dateEnd = DateTime.Now;
						parametrs.Add("Time="+dateEnd.ToString());
						XMLLogWriter.XMLWriteLog("End", parametrs);
						KeepWork = false;
						//Do it!
						break;
					default:
						Console.Write("uncorrect value!\n"); 
						break;
				}
			}
		}
		
	}
}

