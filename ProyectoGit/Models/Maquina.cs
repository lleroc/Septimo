using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoGit.Models
{
    public class Maquina
    {

        public int MaquinaId { get; set; }
        public string nombre_maquina { get; set; }

        public string serie { get; set; }

        public string descripcion { get; set; }

        public string fecha_ingres { get; set; }

    }
}
