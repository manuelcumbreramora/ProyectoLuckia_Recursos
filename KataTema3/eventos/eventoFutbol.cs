using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTema3
{
    class eventoFutbol : IEvento
    {
        int apuesta, resultado, ganancia;

        public Boolean resultadoEvento()
        {
            Console.WriteLine("Quién va a ganar??");
            Console.WriteLine("0: empate; 1: gana local; 2: gana visitante");
            apuesta = Int32.Parse(Console.ReadLine());
            

            Random r = new Random();
            resultado = r.Next(0, 3);
            //0 empate, 1 gana local y 2 gana visitante

            if(apuesta == resultado)
            {
                Console.WriteLine("Has ganado");
                return true; 
            }
            else
            {
                Console.WriteLine("Ha perdido");
                return false;
            }
        }

        public int ganaciaObtenida()
        {
            //Generamos una ganancia aleatoria. En el futuro, hay que hacer ganancia = cuota*importeApostado
            Random r = new Random();
            ganancia = r.Next(50, 100);
            return ganancia;

        }



    }
}
