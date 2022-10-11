using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Periodista : Persona, IValidable
    {

        public string Email { get; set; }
        public string Password { get; set; }

        public Periodista(int id, string nombre, string email, string password) : base(id, nombre)
        {
            this.Id = id;
            this.NombreCompleto = nombre;
            this.Email = email;
            this.Password = password;
        }

        public Periodista()
        {

        }

        public void Validar()
        {
            if (this.NombreCompleto == "") throw new Exception("El nombre no puede ser vacio \n");
            bool EsNumero = int.TryParse(this.NombreCompleto, out int opc);
            if (EsNumero == true)
            {
                throw new Exception("El nombre no puede ser numerico \n");
            }
            


            //**VALIDAR MAIL**\\

            if (Email.Length <= 0)
            {
                throw new Exception("No puedes dejar el campo de Email vacio \n");
            }
            if (Password.Length <= 0)
            {
                throw new Exception("No puedes dejar la contraseña vacia \n");
            }
            for (int i = 0; i < Email.Length; i++)
            {
                if (Email.EndsWith("@") || Email.StartsWith("@"))
                {
                    throw new Exception("El email no puede empezar ni terminar con arroba \n");
                }
                if (Email.IndexOf("@") == -1)
                {
                    throw new Exception("El email tiene que tener arroba \n");
                }
            }

            //**VALIDAR PASSWORD**\\
            for (int i = 0; i < Email.Length; i++)
            {
                if (Password.Length < 8)
                {
                    throw new Exception("La contraseña debe tener al menos 8 caracteres \n");
                }
            }
        }



    }
}
