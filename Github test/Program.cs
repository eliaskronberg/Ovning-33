using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world" );
            Console.WriteLine("nämen hallå!");
            Console.WriteLine("GIT är Gut som en guzz");
            Klassen klass = new Klassen();
            Console.WriteLine("skriv något som du inte vill äta");
            string banan = Console.ReadLine();
            string namn = "Marcus Vall Enberg";
            Console.WriteLine(namn + " brukar äta en " + banan);
        }
    }
}
