using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaygoDoc
{
    public class MetodoMAIN : MetodosMODEL
    {
        public List<string> Metodos { get; set; }

        public List<string> GetMetodos()
        {
            foreach (var item in Enum.GetNames(typeof(Metodos)))
            {
                if (!item.Equals("Todos"))
                {
                    Metodos.Add(item);
                }                
            }
            return Metodos;
        }
    }
}
