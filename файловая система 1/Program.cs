using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace файловая_система_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Begin:
            Console.Write("Введите полное имя папки: C:\\");
            string userdir = Console.ReadLine();
            string dirname = "C:\\" + userdir;
            if (Directory.Exists(dirname))
            {
                string[] files = Directory.GetFiles(dirname);
                foreach (string s in files)
                {
                    Console.WriteLine($"--- {s}");
                }

                string[] dirs = Directory.GetDirectories(dirname);
                foreach (string s in dirs)
                {
                    Console.WriteLine($"-↓- {s}");
                    string[] files2 = Directory.GetFileSystemEntries(s);
                    foreach (string s2 in files2)
                    {
                        Console.WriteLine($"    --- {s2}");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Ошибка! Папка не существует!");
                goto Begin;
            }
            Console.ReadLine();
        }
    }
}
