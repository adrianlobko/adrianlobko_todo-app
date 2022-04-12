using System;
using System.IO;
using System.Linq;

namespace toDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                Console.WriteLine($"Command Line Todo application \n============================= \n Command line arguments: \n" +
                                  $" -l   Lists all the tasks \n" +
                                  $" -a   Adds a new task \n" +
                                  $" -r   Removes an task \n" +
                                  $" -c   Completes an task");
                Console.ReadLine();
                return;
            }


            if (args[0] == "-l")
            {
                string path = @"C:\toDoApp\toDoApp\toDoApp.txt";
                if (new FileInfo(path).Length != 0)
                {
                    string[] array = File.ReadAllLines(path);
                    int order = 1;

                    foreach (string line in array)
                    {
                        Console.WriteLine(order + " - " + line);
                        order++;
                    }
                }
                else
                {
                    Console.WriteLine("No todos for today! :)");
                }
                return;
            }
            

            if (args[0] == "-a")
            {
                string path = @"C:\toDoApp\toDoApp\toDoApp.txt";
                string newTask = args[1];
                if (newTask == String.Empty)
                {
                    Console.WriteLine("Unable to add: no task provided");
                }
                else
                {
                    File.AppendAllText(path, $"\n{newTask}");
                    Console.WriteLine($"New task added '{args[1]}'");
                }
            }


            if (args[0] == "-r")
            {
                string path = @"C:\toDoApp\toDoApp\toDoApp.txt";



            }
        }
    }
}

