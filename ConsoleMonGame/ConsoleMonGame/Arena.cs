using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;

namespace ConsoleMonGame
{
    internal class Arena
    {
        internal void Fight(ConsoleMon fighterA, ConsoleMon fighterB)
        {

            fighterA.skills[0].UseOn(fighterB, fighterA);
            Console.WriteLine($"{fighterA} used {fighterA.skills[0].name} on {fighterB}\n");
            fighterB.skills[0].UseOn(fighterA, fighterB);
            Console.WriteLine($"{fighterB} used {fighterB.skills[0].name} on {fighterA}\n");
        }
        internal void Display(ConsoleMon fighterA, ConsoleMon fighterB) 
        {
            
            
        }
        
    }
}
