using Poo.Models.Personas.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo.Models.Personas
{
    public class Profesor : IPersona
    {
        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public Profesor()
        {
                
        }

        public Profesor(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }
        public string getNombre()
        {
            var nombre = $"el nombre es {Nombre}";

            return nombre;
        }

        public string setNombre()
        {
            throw new NotImplementedException();
        }
    }
}
