using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
   public class Incidencia
    {
        public Jugador Jugador { get; set; }
        public string TipoIncidencia { get; set; }
        public int Minuto { get; set; }
        
        
        public Incidencia(Jugador jugador, string tipoIncidencia, int minuto)
        {
            this.Jugador = jugador;
            this.TipoIncidencia = tipoIncidencia;
            this.Minuto = minuto;
           
        }
        
        public override string ToString()
        {
            return this.Jugador.NombreCompleto;
        }
    }
}
