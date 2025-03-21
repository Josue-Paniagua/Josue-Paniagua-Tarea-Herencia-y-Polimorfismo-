using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Camion : Vehiculo
    {
        private string gasolina;
        private int capacidadCarga;
        private int potencia;

        public Camion(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            this.gasolina = "Diesel";
            this.capacidadCarga = 0;
            this.potencia = 200;
        }
        public void cargaTOTAL(int capacidadCarga)
        {
            if (capacidadCarga > 1000)
            {
                Console.WriteLine("No se puede cargar mas de 1000 libras ");
            }
            else
            {
                Console.WriteLine("Cargando..." );
            }  
        }
        public override void CargarGaso(int gasolina) 
        {
            {
                if (gasolina == 0)
                {
                    Console.WriteLine("NO es necesario cargar gasolina");
                }
                else
                {

                    Console.WriteLine("Cargando gasolina");
                }
            }
        }
    }
}
