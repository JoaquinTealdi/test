using Poo.Models.Vehiculos.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo.Models.Vehiculos
{
    public class Auto : IAuto
    {
        public Auto()
        {
                
        }
        public void Acelerar()
        {
            Console.WriteLine("Auto acelerando");
        }

        public void Apagar()
        {
            Console.WriteLine("Auto apagado");
        }

        public void Doblar()
        {
            Console.WriteLine("Auto doblando");
        }

        public void Encender()
        {
            Console.WriteLine("Auto encendido");
        }

        public void Frenar()
        {
            Console.WriteLine("Auto frenando");
        }
    }
}
