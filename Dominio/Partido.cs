using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Partido : IValidable
    {
        public int Id { get; set; }
        public List<Seleccion> Selecciones { get; set; } = new List<Seleccion>();
        public DateTime FechaYHora { get; set; }
        public List<Incidencia> Incidencias { get; } = new List<Incidencia>();
        public bool Finalizado { get; set; }
        public string Resultado { get; set; }

        public Partido(int id, List<Seleccion> seleccion, DateTime fechayhora, bool finalizado, string resultado)
        {
            this.Id = id;
            this.Selecciones = seleccion;
            this.FechaYHora = fechayhora;
            this.Finalizado = finalizado;
            this.Resultado = resultado;


        }
        public Partido() { }
        public void Validar()
        {

            if (this.FechaYHora < DateTime.Parse("2022-11-20") || this.FechaYHora > DateTime.Parse("2022-12-18")) throw new Exception("La fecha debe ser valida");
            foreach (Seleccion s in Selecciones)
            {
                if (Selecciones.Count <= 1)
                {
                    throw new Exception("Las selecciones deben ser dos y debene estar cargadas.");
                }
            }
        }


        public void AñadirGol()
        {
            foreach (Incidencia i in Incidencias)
            {
                if (i.TipoIncidencia == "Gol")
                {
                    Incidencias.Add(i);
                }
            }
        }

        public void AgregarIncidencia(Incidencia incidencia)
        {

            Incidencias.Add(incidencia);

        }

        public override string ToString()
        {

            foreach (Seleccion s in Selecciones)
            {
                Seleccion pais1 = Selecciones[0];
                Seleccion pais2 = Selecciones[1];
                return "Fecha y Hora: " + this.FechaYHora + "\n Selecciones: " + pais1 + " VS " + pais2 + "\n Cantidad de incidencias: " + this.Incidencias.Count + "\n";
            }

            return "";
        }
    }
}
