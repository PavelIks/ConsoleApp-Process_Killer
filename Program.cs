using System;
using System.Diagnostics;

namespace ProcessKiller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string ");
            string str = Console.ReadLine();
            foreach (Process process in Process.GetProcessesByName(str))
            {
                process.Kill();
                Console.WriteLine("Процесс убит.");
            }
            Console.Read();

            /*foreach (Process process in Process.GetProcessesByName("Firefox"))
            {
                process.Kill();
                Console.WriteLine("Процесс убит.");
            }
            Console.Read();*/
        }
    }
}