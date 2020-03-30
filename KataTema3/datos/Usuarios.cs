using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTema3
{
    public class Usuarios
    {
        public Usuarios()
        {
        }

        public Usuarios(string ID, string nombre, string apellido, int edad, string pass)
        {
            this.ID = ID;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        //Con esta clase creo una lista de usuarios que admite (frente al arraylist) datos heterogéneos

        public string ID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public string pass { get; set; }
        public String key { get; set; }
        public string dbpass;

        public List<Usuarios> UserList;

        //Creamos y llenamos la lista de eventos

        public void crearListaUsuarios()
        {

            List<Usuarios> UserList = new List<Usuarios>();

            UserList.Add(new Usuarios("0001", "Pepito", "Pérez", 35, "abc"));
            UserList.Add(new Usuarios("0002", "Menganito", "Mengánez", 18, "abc123.."));
            UserList.Add(new Usuarios("0003", "Fulanito", "Fulánez", 15, "abc123..."));
            UserList.Add(new Usuarios("0004", "Odín", "Odinez", 45, "bca"));
            UserList.Add(new Usuarios("0005", "Okami", "Okamez", 99, "aba"));
            UserList.Add(new Usuarios("0006", "Pulgui", "Pulguez", 67, "bbc"));
            
        }

        public void addUser(string ID, string nombre, string apellido, int edad) 
        
        {
            UserList.Add(new Usuarios(ID, nombre, apellido, edad, pass));
            Console.WriteLine("Bienvenido " + nombre + ", tu usuario ha sido creado correctamente");
        }

        public string getPass()
        {
            //La próxima vez usaré dictionary para esto
           Console.WriteLine("Introduzca su código de usuario");
           key = Console.ReadLine();
           dbpass = "abc";
           //UserList.Find(x => x.ID.Contains(key));
            return dbpass;



            /* Find items where name contains "seat".
            Console.WriteLine("\nFind: Part where name contains \"seat\": {0}",
            parts.Find(x => x.PartName.Contains("seat")));
            // Check if an item with Id 1444 exists(interesate para user no valid).
         Console.WriteLine("\nExists: Part with Id=1444: {0}", 
             parts.Exists(x => x.PartId == 1444));
            */
        }

    }
}