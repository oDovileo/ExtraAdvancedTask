using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExtraAdvancedTask
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();

            string command = "";
            Console.WriteLine("Posible commands: Exit");
          
            while (command != "Exit")
            {
                String response = await client.GetStringAsync("https://jsonplaceholder.typicode.com/users");                
                List<Item> parsedResponse = JsonConvert.DeserializeObject<List<Item>>(response);
                Console.WriteLine("-> Please enter the name and You will get all info");
                command = Console.ReadLine();
                string name = command.Split(" ")[0];
                Item a = parsedResponse.First(a => a.Name.StartsWith(name));
                Console.WriteLine(a.ToString());                                
            }
                command = Console.ReadLine();            
        }
    }
}
