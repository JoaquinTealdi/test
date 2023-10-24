using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo.Models.Personas.Contratos
{
    public interface IPersona
    {
        public string Nombre { get; set; }
        public string getNombre();
        public string setNombre(string nombre);
    }
}
