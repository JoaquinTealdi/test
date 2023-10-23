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

        public Profesor()
        {
                
        }

        public Profesor(string nombre)
        {
            Nombre = nombre;    
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
