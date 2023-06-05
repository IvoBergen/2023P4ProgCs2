using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMonFactory
    {
        internal void Load(string datafile)
        {
            
            
            string[] lines = File.ReadAllLines(datafile);
             
            for (int i = 0; i < lines.Length; i++) 
            {
                string[] typeSplit = lines[i].Split('|');
                string[] consoleMonData = typeSplit[0].Split(",");
                //Console.WriteLine(consoleMonData);
                ConsoleMon dataMon = new ConsoleMon();
                dataMon.name = consoleMonData[0];
                dataMon.energy = int.Parse(consoleMonData[4]);
                dataMon.health = int.Parse(consoleMonData[2]);
                Console.WriteLine(dataMon.name);
                Console.WriteLine(dataMon.energy);
                Console.WriteLine(dataMon.health);

            }
        }

        internal void LoadJson(string datafile) 
        { 
            string json = File.ReadAllText(datafile);
            List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);
            Console.WriteLine(templates[0].name);
            
           
        }
    }
    
}
