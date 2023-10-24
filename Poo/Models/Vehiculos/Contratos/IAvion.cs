using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo.Models.Vehiculos.Contratos
{
    public interface IAvion
    {
        public void Despegar();
        public void Aterrizar();
        public void Encender();
        public void Apagar();
    }
}
