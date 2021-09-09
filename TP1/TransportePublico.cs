using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    public abstract class TransportePublico
    {
     
        public bool EnMovimiento { get; set; }
        public int Pasajeros { get; set; }

        public string Descripcion { get; set; }

        public abstract void Avanzar();


        public abstract void Detenerse();
     
    }


}
