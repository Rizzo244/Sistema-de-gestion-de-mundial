using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class FaseGrupo : Partido
    {
        public string NombreGrupo { get; set; }

       

        public FaseGrupo(int id, List<Seleccion> seleccion, DateTime fechayhora, bool finalizado, string resultado,string nombregrupo)
        {
            this.Id = id;
            this.Selecciones = seleccion;
            this.FechaYHora = fechayhora;
            this.Finalizado = finalizado;
            this.Resultado = resultado;
            this.NombreGrupo = nombregrupo;
            
        }
        public FaseGrupo() { }
    }
}
