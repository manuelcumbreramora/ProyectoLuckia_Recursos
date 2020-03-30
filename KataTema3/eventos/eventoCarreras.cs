using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTema3
{
    class eventoCarreras : IEvento
    {
        int apuesta, resultado, ganancia;
        
        public Boolean resultadoEvento()
        {
            Console.WriteLine("Quién va a ganar??");
            Console.WriteLine("Introduzca número de piloto, de 1 a 15");
            apuesta = Int32.Parse(Console.ReadLine());
            

            Random r = new Random();
            resultado = r.Next(1, 16);
            //0 empate, 1 gana local y 2 gana visitante

            if (apuesta == resultado)
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
