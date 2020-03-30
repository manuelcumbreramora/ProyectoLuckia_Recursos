using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTema3
{
    class Persona
    {

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public Persona()
        {
        }

        public string ID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }

        public string pass { get; set; }

        public int numID = 6;


        public void realizarSuscripcion()
        {
            //tengo que hacerlo de forma que la lista de usuarios no se reconstruya de 0
            
            Usuarios u = new Usuarios();

            Console.WriteLine("Introduzca su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Introduzca su primer apellido");
            apellido = Console.ReadLine();
            Console.WriteLine("Introduzca su edad");
            edad = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca su contraseña");
            pass = Console.ReadLine();

            //Generamos nuevas ID automaticamente
            numID = numID + 1;
            ID = numID.ToString().PadLeft(4, '0');
            
            u.addUser(ID, nombre, apellido, edad);
            

        }
    }
}
