namespace FileDirOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\ivobe\Desktop\Ma\Bewijzenmap\periode1.4\prog4\2023P4ProgCs2");
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files) 
            { 
                Console.Write(file.FullName);
            }
            DirectoryInfo[] di = dir.GetDirectories();
            foreach (DirectoryInfo di2 in di) 
            { 
                Console.WriteLine(di2.);
            }
        }
    }
}