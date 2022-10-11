using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public abstract class Persona
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        

        public Persona(int id, string nombre)
        {
            this.Id = id;
            this.NombreCompleto = nombre;
        }

        public Persona()
        {

        }

        //public void Validar()
        //{

        //}
    }
}
