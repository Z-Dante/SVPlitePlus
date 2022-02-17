using System;
using System.IO;
using System.Text.RegularExpressions;

namespace SVPLiteSetFPS
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            Console.Write("Input Desired Framerate: ");
            var fps = Console.ReadLine();
            foreach (string file in Directory.EnumerateFiles(".", "*.avs"))
            {
                string contents = File.ReadAllText(file);
                contents = Regex.Replace(contents, "{num:[0-9]*,", "{num:" + fps + ",");
                File.WriteAllText(file, contents);
            }
            Console.WriteLine("Done!");
            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
    }
}