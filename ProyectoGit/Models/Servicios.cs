using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoGit.Models
{
    public class Servicios
    {
        public int ServicioId { get; set; }
        public string NombreServicio { get; set; }
        public double Precio { get; set; }
        public Boolean Estado { get; set; }
    }
}
