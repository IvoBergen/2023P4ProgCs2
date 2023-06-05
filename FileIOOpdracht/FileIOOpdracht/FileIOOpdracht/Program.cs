using System.Diagnostics;

namespace FileIOOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string relDir = new FileInfo(typeof(Program).Assembly.Location).Directory.FullName;
            string path = Path.Combine(relDir, "leesdezefile.txt");
            string[] content = File.ReadAllLines(path);

            for (int i = 0; i < content.Length; i++) 
            {
                Debug.WriteLine(content[i]);
            }

            string file = Path.Combine(relDir, "mijnnieuwefile.txt");
            File.WriteAllText(file, "hallo");
            
            File.AppendAllText(file, "Hello World!");

            string directory = Path.Combine(relDir, "output");
            Directory.CreateDirectory(directory);

            string newLocation = Path.Combine(directory, "mijnnieuwefile.txt");
            File.Move(file, newLocation,true);

        }
    }
}