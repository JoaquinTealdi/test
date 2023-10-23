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
        public Profesor()
        {
                
        }

        public Profesor(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
        public string getNombre()
        {
            throw new NotImplementedException();
        }

        public string setNombre()
        {
            throw new NotImplementedException();
        }
    }
}
