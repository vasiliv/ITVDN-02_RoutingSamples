using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new Dictionary<string, string>(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };
            Console.WriteLine("Key: {0}, Value: {1}", cities.ElementAt(0).Key, cities.ElementAt(0).Value);
            Console.ReadKey();
        }
    }
}
