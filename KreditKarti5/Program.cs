using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KreditKarti5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Istifadeci Adini Daxil Edin");
            string username = Console.ReadLine();
            Console.WriteLine("Parolu Daxil Edin");
            string password = Console.ReadLine();
            Kart crd = new Kart(username,password);
        }
    }
}
