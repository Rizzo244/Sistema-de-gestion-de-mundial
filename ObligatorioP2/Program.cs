using System;
using System.Collections.Generic;
using Dominio;
namespace ObligatorioP2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            Sistema sistema = Sistema.ObtenerInstancia;

            while (!salir)
            {
                Console.WriteLine("**Gestion de Actividad del Mundial QATAR 2022**");
                Console.WriteLine("");
                Console.WriteLine("Seleccione una opcion: ");
                Console.WriteLine("");
                Console.WriteLine("1 - Alta de Periodista.");
                Console.WriteLine("2 - Asignar valor de referencia para categoria financiera.");
                Console.WriteLine("3 - Ingresar ID de jugador para ver en que partidos participó.");
                Console.WriteLine("4 - Listado de jugadores que fueron expulsados al menos una vez.");
                Console.WriteLine("5 - Listado de Partidos con mas goles de una Seleccion.");
                Console.WriteLine("6 - Listado de jugadores que hicieron mas de un gol.");
                Console.WriteLine("");
                Console.WriteLine("0 - Salir.");

                bool correcto = int.TryParse(Console.ReadLine(), out int opcion);
                if (!correcto)
                {
                    Console.WriteLine("Opción inválida. Debe ingresar un valor numérico.");
                }
                else
                {
                    switch (opcion)
                    {
                        case 1:
                            AltaPeriodista(sistema);
                            break;
                        case 2:
                            AsignarValorReferencia(sistema);
                            break;
                        case 3:
                            JugadorPartidosParticipo(sistema);
                            break;
                        case 4:
                            ListadoJugadoresExpulsados(sistema);
                            break;
                        case 5:
                            ListadoPartidosMasGoles(sistema);
                            break;
                        case 6:
                            ListadoJugadoresUnGol(sistema);
                            break;

                        case 0:
                            Console.WriteLine("Saliendo del sistema...");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("No existe esa opción. Ingrese nuevamente");
                            break;

                    }
                }

            }

        }

        //**METODOS SEGUN CUAL OPCION SE ELIGIO**\\
        public static void ListadoPartidosMasGoles(Sistema sistema)
        {
            Console.Clear();
            Console.WriteLine("Ingrese una seleccion: ");
            string seleccion = Console.ReadLine();


            try
            {

                List<Partido> partidos = sistema.ObtenerPartidosMasGolesSeleccion(seleccion);
                if (partidos.Count == 0)
                {
                    Console.WriteLine("No existen Partidos en la lista.");
                    Console.WriteLine("Presione enter para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                    return;

                }
                foreach (Partido p in partidos)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }




            Console.WriteLine("");
        }

        //**ALTA DE UN PERIODISTA**\\
        public static void AltaPeriodista(Sistema sistema)
        {
            Console.Clear();
            int id = 0;
            Console.WriteLine("Ingrese nombre completo:");
            string nombreCompleto = Console.ReadLine();
            Console.WriteLine("Ingrese su email:");
            string email = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña:");
            string password = Console.ReadLine();
            try
            {
                ;
                sistema.AltaPeriodista(id, nombreCompleto, email, password);
                Console.WriteLine("Periodista dado de alta correctamente\n");
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }




        public static void AsignarValorReferencia(Sistema sistema)
        {
            Console.Clear();


            Console.WriteLine("Ingrese un valor de referencia: ");
            bool valorNumerico = int.TryParse(Console.ReadLine(), out int opcion);
            int valor = opcion;
            try
            {
                sistema.CambiarMontoReferenciaJugador(valor);
                Console.WriteLine("Valor asignado correctamente \n");
                Console.WriteLine("El monto es: " + valor + "\n");

                Console.WriteLine("Presione enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }


        }

        public static void JugadorPartidosParticipo(Sistema sistema)
        {
            Console.Clear();

            Console.WriteLine("Ingrese ID de jugador: ");
            bool validarIdNumerico = int.TryParse(Console.ReadLine(), out int opcion);
            int id = opcion;
            try
            {

                List<Partido> partidos = sistema.JugadorParticipoEnPartido(id);
                if (partidos.Count == 0)
                {
                    Console.WriteLine("No existen Partidos en la lista.");
                    Console.WriteLine("Presione enter para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                    return;

                }
                foreach (Partido p in partidos)
                {
                    Console.WriteLine(p);

                }
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }
        public static void ListadoJugadoresExpulsados(Sistema sistema)
        {
            Console.Clear();
            List<Jugador> jugadores = sistema.JugadoresExpulsados();
            List<Jugador> incidencias = sistema.ObtenerJugadoresOrdenados(jugadores);
            if (incidencias.Count == 0)
            {
                Console.WriteLine("No existen jugadores expulsados.");
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                return;

            }

            Console.WriteLine("Listado de Jugadores:");
            foreach (Jugador i in incidencias)
            {

                Console.WriteLine(i);


            }
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadLine();
            Console.Clear();

        }
        public static void ListadoJugadoresUnGol(Sistema sistema)
        {
            Console.Clear();
            Console.WriteLine("Ingrese un ID de un partido: ");
            bool boolId = int.TryParse(Console.ReadLine(), out int opc);
            int id = opc;
            List<Jugador> jugadores = sistema.ObtenerJugadoresHicieronUnGol(id);

            if (jugadores.Count == 0)
            {
                Console.WriteLine("Ingrese un ID valido.");
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                return;

            }

            Console.WriteLine("Listado de Jugadores:");
            foreach (Jugador j in jugadores)
            {

                Console.WriteLine(j);

            }
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadLine();
            Console.Clear();

        }


    }
}



