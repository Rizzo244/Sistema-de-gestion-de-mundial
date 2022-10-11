using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class FaseEliminatoria : Partido
    {
        
        public bool HuboAlargue { get; set; }
        public bool HuboPenales { get; set; }
        public string EtapaPertenece { get; set; }
        public Seleccion Ganador { get; set; }

        public FaseEliminatoria(int id, List<Seleccion> seleccion, DateTime fechayhora, bool finalizado, string resultado, bool huboalargue,bool hubopenales, string etapapertenece)
        {
            this.Id = id;
            this.Selecciones = seleccion;
            this.FechaYHora = fechayhora;
            this.Finalizado = finalizado;
            this.Resultado = resultado;
            this.HuboAlargue = huboalargue;
            this.HuboPenales = hubopenales;
            this.EtapaPertenece = etapapertenece;
        }
        public FaseEliminatoria() 
        {
            
        }
        }
    }

