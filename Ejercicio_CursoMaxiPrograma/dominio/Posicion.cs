
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Posicion
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Puesto { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
