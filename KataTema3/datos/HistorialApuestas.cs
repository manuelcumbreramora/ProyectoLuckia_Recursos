using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTema3
{
    class HistorialApuestas
    {
        public HistorialApuestas()
        {
        }

        public HistorialApuestas(DateTime fechaApuesta, string titleEvento, int importe, int ganancia)
        {
            FechaApuesta = fechaApuesta;
            this.titleEvento = titleEvento;
            this.importe = importe;
            this.ganancia = ganancia;
        }

        List<HistorialApuestas> historialApuestas;

        public DateTime FechaApuesta { get; set; }
        public string titleEvento { get; set; }
        public int importe { get; set; }
        public int ganancia { get; set; }


        public void crearHistorialApuestas()
        {
            List<HistorialApuestas> historialApuestas = new List<HistorialApuestas>();
                
        }

        public void aniadirApuesta(DateTime FechaApuesta, string titleEvento, int importe, int ganancia)
        {
            historialApuestas.Add(new HistorialApuestas(FechaApuesta , titleEvento, importe, ganancia));

        }

    }
}
