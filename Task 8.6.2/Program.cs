using System;
using System.IO;

namespace Task_8._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите путь к каталогу");
            string Path = Console.ReadLine();

            var asd = FolderSize(Path);

            Console.WriteLine("Размер папки {0} байт", asd);

            static long FolderSize(string Path)
            {
                long i = 0;
                DirectoryInfo DrInfo = new DirectoryInfo(Path);
                DirectoryInfo[] folder = DrInfo.GetDirectories();
                FileInfo[] Fi = DrInfo.GetFiles();

                foreach (FileInfo fl in Fi)
                {
                    i += fl.Length;
                }

                for (int j = 0; j < folder.Length; j++)
                {
                    i += FolderSize(Path + "\\" + folder[j].Name);
                }

                return i;
            }
        }
    }
}
