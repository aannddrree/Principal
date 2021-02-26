using Logical;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cli = new Client()
            {
                Id = 1,
                Nome = "andre",
                Telefone = "16 99887744"
            };

            Console.WriteLine(Print.show(cli));
            Console.ReadKey();
        }
    }
}
