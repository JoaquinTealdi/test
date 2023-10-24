using Poo.Models.Vehiculos.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo.Models.Vehiculos
{
    internal class Avion : IAvion
    {
        public Avion()
        {
                
        }
        public void Apagar()
        {
            Console.WriteLine("Avion apagado");
        }

        public void Aterrizar()
        {
            Console.WriteLine("Avion aterrizando");
        }

        public void Despegar()
        {
            Console.WriteLine("Avion despegando");
        }

        public void Encender()
        {
            Console.WriteLine("Avion encendido");
        }
    }
}
