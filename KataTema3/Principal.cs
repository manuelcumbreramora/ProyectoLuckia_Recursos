/*Luckia necesita implementar su nuevo proceso de apuestas OnLine. Para ello, se especifica lo siguiente.
El Jugador, debe autenticarse en la plataforma,y, debe llenar su monedero para poder realizar las apuestas.
Sólo si tiene cash en su monedero, se le permitirá ver el listado de los eventos disponibles (Fútbol,Baloncesto,F1).
Podrá realizar las apuestas que quiera, y a los eventos que quiera.
El sistema automático de apuestas de Luckia, identificará las apuestas, las procesará, evaluará los resultados y 
hará el ingreso en caso de acierto.
El usuario, podrá revisar sus apuestas, consultando su historial.

Se pide implementar Clases e Interfaces necesarias, aplicando correctamente herencia y respetando los conceptos de cohesión y bajo acoplamiento y principio de única responsabilidad
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTema3
{
    class Principal
    {
        static void Main(string[] args)
        {

            //Inicialización de variables
            int eleccion2 = 0;
            int eleccion1 = 0;
            int ganancia, dineroApostado;
            Boolean log;

            //Inicialización de objetos
            Jugador j = new Jugador();
            Monedero mone = new Monedero();
            Eventos e = new Eventos();
            HistorialApuestas hist = new HistorialApuestas();
            Usuarios u = new Usuarios();

            //SignIn or LogIn
            Console.WriteLine("Bienvenido a Luckia. Qué desea hacer??");
            Console.WriteLine("1: Quiero crear una cuenta nueva");
            Console.WriteLine("2: Quiero entrar en el sistema con mi usuario y contraseña");
            eleccion1 = Int32.Parse(Console.ReadLine());

            switch (eleccion1)
            {
                case 1:
                    j.realizarSuscripcion();
                    break;

                case 2:
                    log = j.login(u);
                    if (log == true)
                    {
                        Console.WriteLine("Bienvenido a Luckia, logueado correctamente");
                    }
                    //Habría que meter un while para loguearse correctamente
                    break;
                default:
                    Console.WriteLine("No le hemos entendido. Qué desea hacer??");
                    break;

            }



            //Apuestas
            while (eleccion2 != 6)
            {
                j.menu();
                eleccion2 = Int16.Parse(Console.ReadLine());
                switch (eleccion2)
                {
                    case 1:
                        if (mone.comprobarSaldo() == true)
                        {
                            e.crearListaEventos();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No tiene saldo. Recargue su monedero para apostar");
                            break;
                        }
                        
                    case 2:
                        eventoFutbol ef = new eventoFutbol();
                        mone.apostar();
                        if (ef.resultadoEvento() == true)
                        {
                            ganancia = ef.ganaciaObtenida();
                            mone.actualizarSaldo(ganancia);

                        }
                        else
                        {
                            ganancia = 0;

                        }

                        Console.WriteLine("Su saldo es de " + mone.consultarSaldo() + " euros");
                        dineroApostado = mone.dineroApostado;
                        hist.aniadirApuesta(new DateTime(2020, 03, 25), "tituloEvento", dineroApostado, ganancia);
                        break;
           
                    case 3:
                        eventoBasket eb = new eventoBasket();
                        mone.apostar();
                        if (eb.resultadoEvento() == true)
                        {
                            ganancia = eb.ganaciaObtenida();
                            mone.actualizarSaldo(ganancia);

                        }

                        else
                        {
                            ganancia = 0;

                        }

                        Console.WriteLine("Su saldo es de " + mone.consultarSaldo() + " euros");
                        dineroApostado = mone.dineroApostado;
                        hist.aniadirApuesta(new DateTime(2020, 03, 25), "tituloEvento", dineroApostado, ganancia);
                        break;


                    case 4:
                        eventoCarreras ec = new eventoCarreras();
                        mone.apostar();
                        if (ec.resultadoEvento() == true)
                        {
                            ganancia = ec.ganaciaObtenida();
                            mone.actualizarSaldo(ganancia);

                        }

                        else
                        {
                            ganancia = 0;

                        }

                        Console.WriteLine("Su saldo es de " + mone.consultarSaldo() + " euros");
                        dineroApostado = mone.dineroApostado;
                        hist.aniadirApuesta(new DateTime(2020, 03, 25), "tituloEvento", dineroApostado, ganancia);
                        break;

                    case 5:
                        mone.recargarMonedero();
                        break;

                    case 6:
                        break;
  
                    default:
                        Console.WriteLine("Valor no válido, ingrese un nuevo valor");
                        break;
                
                }


            }

            Console.WriteLine("Esperamos volver a verle pronto");
            Console.ReadLine();

        }
    }
}
