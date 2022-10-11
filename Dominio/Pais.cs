using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Pais : IValidable
    {
        public int idPais { get; set; }
        public string Nombre { get; set; }
        public string Alpha3 { get; set; }

        public List<Pais> paises = new List<Pais>();
        public Pais(string nombre, string alpha3)
        {
            ;
            this.Nombre = nombre;
            this.Alpha3 = alpha3;
        }

        public Pais()
        {

        }
        public void Validar()
        {
            if (this.Nombre == "")
            {
                throw new Exception("El nombre no puede ser vacio");
            }

            for (int i = 0; i < Alpha3.Length; i++)
            {
                if (Alpha3.Length < 3 || Alpha3.Length > 3)
                {
                    throw new Exception("El codigo alpha 3 debe tener 3 caracteres");
                }
            }
        }

    }
}
