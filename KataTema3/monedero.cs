using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTema3
{
    //Se crea esta clase porque tiene muchas funcionalidades (apostar, dinero, penalizaciones...)
    //Dinero tipodeMoneda y cambiodeDivisa
    //Un usuario puede tener SOLO un monedero
    class Monedero
    {

        int saldo = 0;
        int recarga;
        public int dineroApostado { get; set; }

        /*int ganancia;
        int cuota;*/

        public int recargarMonedero()
        {
            Console.WriteLine("Cuánto dinero quiere cargar en su monedero??");
            recarga = Int16.Parse(Console.ReadLine());
            saldo = saldo + recarga;
            Console.WriteLine("Su saldo actual es de " + saldo + " euros.");
            return saldo;

        }

        public Boolean comprobarSaldo()
        {
            if (saldo > 100)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void apostar()
        {
            Console.WriteLine("Cuánto dinero quiere apostar??");
            dineroApostado = Int32.Parse(Console.ReadLine());
            if (saldo >= dineroApostado)
            {
                saldo = saldo - dineroApostado;
                Console.WriteLine("Apuesta realizada");
            }
            else 
            {
                Console.WriteLine("No se puede realizar la apuesta; Cargue más dinero en su monedero");
            }

        }

        public void actualizarSaldo(int ganancia)
        {
            saldo = saldo + ganancia;

        }

        public int consultarSaldo()
        {
            return saldo;

        }
             



    }
}
