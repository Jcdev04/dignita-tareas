﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entEmpresa
    {
        public string RUC { get; set; }
        public string razon_social { get; set; }
        public string rubro { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public bool inhabilitado { get; set; }
        
    }
}
