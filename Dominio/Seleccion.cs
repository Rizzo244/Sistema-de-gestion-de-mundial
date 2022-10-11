using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Seleccion : IValidable
    {
        public Pais pais { get; set; }

        public List<Jugador> Jugadores { get; } = new List<Jugador>();
        public Seleccion(Pais p, List<Jugador> j)
        {
            this.pais = p;
            this.Jugadores = j;
            
        }

        public Seleccion(Pais p)
        {
            this.pais = p;
        }

        public void Validar()
        {
            if(pais.Nombre == "")
            {
                throw new Exception("Este campo no puede estar vacio");
            }
             if(Jugadores.Count<11)
            {
                throw new Exception("La seleccion debe tener al menos 11 jugadores");
            }
        }

        

        internal void AgregarJugador(Jugador j)
        {
            Jugadores.Add(j);
        }

        public override string ToString()
        {
            return this.pais.Nombre;
        }
    }
}
