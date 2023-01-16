using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string UrlImagen { get; set; }
        public Posicion Posicion { get; set; }

    }
}
