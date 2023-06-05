namespace SplitOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string content = File.ReadAllText("SplitOpdracht.txt");;
            string[] keyvalue = content.Split(':');
            for (int i = 0; i < keyvalue.Length; i++) 
            {
                Console.WriteLine(keyvalue[i]);
            }
            string[] cijfersPerVak = keyvalue[1].Split(',');
            for (int i = 0; i < cijfersPerVak.Length; i++) 
            {
                Console.WriteLine(cijfersPerVak[i]);
            }
            
        }
    }
}