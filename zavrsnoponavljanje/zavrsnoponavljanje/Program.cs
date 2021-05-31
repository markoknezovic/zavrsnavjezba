using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavrsnoponavljanje
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes, seconds, unos;
            Console.WriteLine("upisi sekunde:");
            
            unos = Convert.ToInt32(Console.ReadLine());
            minutes = unos / 60;
            Console.WriteLine(minutes);
            seconds = unos - (minutes*60);
            Console.WriteLine(seconds);
            Console.ReadKey();
        }
    }
}
