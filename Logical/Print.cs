using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    public class Print
    {
        public static string show(Client client)
        {
            return "Id: " + client.Id + " Nome: " + client.Nome;
        }
    }
}
