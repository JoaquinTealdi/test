using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo.Models.Vehiculos.Contratos
{
    public interface IAuto
    {
        public void Acelerar();
        public void Frenar();
        public void Doblar();
        public void Encender();
        public void Apagar();
    }
}
