using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTema3
{
    class Eventos
    {
        //Con esta clase creo una lista de eventos que admite (frente al arraylist) datos heterogéneos

        public DateTime fechaEvento { get; set; }
        public String competicion { get; set; } //Atletismo, Fútbol, Carreras
        public String title { get; set; }

        public Eventos()
        {
        }
        public Eventos(DateTime fechaEvento, String competicion, String title)
        {
            this.fechaEvento = fechaEvento;
            this.competicion = competicion;
            this.title = title;

        }

        //Creamos y llenamos la lista de eventos

        public void crearListaEventos()
        {

            List<Eventos> EventosList = new List<Eventos>();

            EventosList.Add(new Eventos(new DateTime(2020, 03, 25), " Basket ", " Unicaja - Breogán"));
            EventosList.Add(new Eventos(new DateTime(2020, 03, 25), " Basket ", " Estudiantes - Madrid"));
            EventosList.Add(new Eventos(new DateTime(2020, 03, 25), " Basket ", " Barcelona - TAU "));
            EventosList.Add(new Eventos(new DateTime(2020, 03, 25), " Fútbol", " Atlético - Madrid"));
            EventosList.Add(new Eventos(new DateTime(2020, 03, 25), " Fútbol", " Bilbao - Málaga"));
            EventosList.Add(new Eventos(new DateTime(2020, 03, 25), " Fútbol", " Oviedo - Celta"));
            EventosList.Add(new Eventos(new DateTime(2020, 03, 25), " Carreras", " Caballos primera tanda"));
            EventosList.Add(new Eventos(new DateTime(2020, 03, 25), " Carreras", " Caballos segunda tanda"));
            EventosList.Add(new Eventos(new DateTime(2020, 03, 25), " Carreras", " Caballos tercera tanda"));


            int count = 0;
            foreach (var Eventos in EventosList)
            {
                count++;
                Console.WriteLine(count + ": {0},{1},{2}", Eventos.fechaEvento, Eventos.competicion, Eventos.title);
            }
            Console.ReadLine();

        }

    }
}