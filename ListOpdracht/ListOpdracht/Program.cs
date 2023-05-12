using System.Diagnostics;
using System.Runtime.ExceptionServices;

namespace ListOpdracht
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            List<string> birds = new List<string>();
            {
                birds.Add("uil");
                birds.Add("kraai");
                birds.Add("hond");
                birds.Add("papegaai");
            }

            List<string> birds2 = new List<string>();
            {
                birds2.Add("meeuw");
                birds2.Add("duif");
                
            }
            birds.AddRange(birds2);
            birds.Remove(birds[2]);
            for (int i = 0; i < birds.Count; i++)
            {
                Console.WriteLine(birds[i]);
            }
        }
    }
}