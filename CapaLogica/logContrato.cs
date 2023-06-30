using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logContrato
    {
        private readonly static logContrato _instancia = new logContrato();
        public static logContrato Instancia
        {
            get { return logContrato._instancia; }
        }
        public void agregarContrato(entContrato ec)
        {
            datContrato.Instancia.agregarContrato(ec);
        }

        
        public int SeleccionarUltimoContrato()
        {
            return datContrato.Instancia.SeleccionarUltimoContrato();
        }
    }
}
