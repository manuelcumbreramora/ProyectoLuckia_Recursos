using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTema3
{
    class Jugador : Persona
    {
        
        
        public Boolean login(Usuarios u)
        {
            Console.WriteLine("Introduzca su ID");
            ID = Console.ReadLine();
            Console.WriteLine("Introduzca su contraseña");
            pass = Console.ReadLine();

            string id = u.ID;


            if (pass == u.pass)
            {
                return true;
            } else
            {
                return false;
            }

        }

        public void menu()
        {
            Console.WriteLine("Qué desea hacer??");
            Console.WriteLine("1: Ver los eventos disponibles");
            Console.WriteLine("2: Apostar al fútbol");
            Console.WriteLine("3: Apostar al baloncesto");
            Console.WriteLine("4: Apostar a la F1");
            Console.WriteLine("5: Quiero cargar mi monedero");
            Console.WriteLine("6: Log out");

        }


        /*public void apostar()
        //En realidad en eset ejemplo puse el método apostar en el monedero, aunque no tengo claro que sea lo más correcto
        {
            
            Console.WriteLine("Apuesta Realizada");
            var rand = new Random();
            bonus = rand.Next(1, 10);
            Console.WriteLine("Ha obtenido un bonus de " + bonus + " euros");
           
                       
            Console.ReadLine();

        }
        */
    }
}
