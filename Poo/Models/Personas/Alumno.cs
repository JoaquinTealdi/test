using Poo.Models.Personas.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo.Models.Personas
{
    internal class Alumno : IPersona
    {
        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Alumno()
        {
                
        }

        public Alumno(string nombre)
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
