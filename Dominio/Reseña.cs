using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Reseña
    {

        public Periodista Periodista { get; set; }
        public DateTime FechaReseña { get; set; }
        public Partido Partido { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }
    }
}
