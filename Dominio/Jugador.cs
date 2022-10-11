using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Jugador : Persona, IValidable, IComparable
    {

        public string NumeroCamiseta { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Altura { get; set; }
        public string PieHabil { get; set; }
        public int ValorMercado { get; set; }
        public static int MontoReferencia { get; set; }
        public string TipoMoneda { get; set; }
        public Pais PaisPertenece { get; set; }
        public string Posicion { get; set; }
        public string Categoria { get; set; }
        public Jugador(int id, string numCamiseta, string nombre, DateTime fechaNacimiento, double altura, string piehabil, int valorMercado, string tipoMoneda, Pais paisPertenece, string posicion) : base(id, nombre)
        {
            this.Id = id;
            this.NombreCompleto = nombre;
            this.NumeroCamiseta = numCamiseta;
            this.FechaNacimiento = fechaNacimiento;
            this.Altura = altura;
            this.PieHabil = piehabil;
            this.TipoMoneda = tipoMoneda;
            this.ValorMercado = valorMercado;
            this.PaisPertenece = paisPertenece;
            this.Posicion = posicion;
            AsignarCategoria();
        }

        public Jugador()
        {

        }




        public void Validar()
        {
            if (this.NombreCompleto == "") throw new Exception("El nombre no puede ser vacio");
            if (this.NumeroCamiseta == "") throw new Exception("El numero de camiseta no puede ser vacio");
            if (this.FechaNacimiento == DateTime.Parse("0000-00-00")) throw new Exception("La fecha debe ser valida");
            if (this.Altura <= 0) throw new Exception("La altura no puede ser negativa ni 0");
            if (this.PieHabil == "") throw new Exception("Este campo no puede estar vacio");
            if (this.Posicion == "") throw new Exception("Este campo no puede estar vacio");
            if (this.ValorMercado <= 0) throw new Exception("El valor de mercado debe ser un valor mayor a 0");
        }


        public string AsignarCategoria()
        {

            if (this.ValorMercado > MontoReferencia)
            {
                this.Categoria = "VIP";
            }
            else
            {
                this.Categoria = "Estandar";
            }
            return Categoria;
        }
        
        public int CompareTo(Object obj)
        {
            //Metodo para ordenar los jugadores por valor de mercado descendente, o alfabeticamente
            Jugador Comparado = (Jugador)obj;
            int ordenar = Comparado.ValorMercado.CompareTo(this.ValorMercado);
            if(ordenar == 0)
            {
                ordenar = Comparado.NombreCompleto.CompareTo(this.NombreCompleto);
            }
            return ordenar;

        }

        public override string ToString()
        {
            return "Nombre: " + this.NombreCompleto + "\n Valor Mercado: EUR" + this.ValorMercado + "\n Categoria Financiera: " + AsignarCategoria() + "\n";
        }
    }
}

