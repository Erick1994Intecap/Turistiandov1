using System;
using System.Collections.Generic;
using System.Text;

namespace Turistiando.Model
{
    public class RecoCategoriaModel
    {
        public string Lugar_Turistico { get; set; }
        public string Departamento { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Region { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int Puntuacion { get; set; }
        public int Visitas { get; set; }
    }
}
