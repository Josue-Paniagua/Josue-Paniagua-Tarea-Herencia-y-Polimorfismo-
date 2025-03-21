using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class moto : Vehiculo
    {
        private int cilindraje;
        private int velocidad;
        private int nivelGasolina;

        public moto(int anio, string elColor, string elModelo, int cilindraje) : base(anio, elColor, elModelo)
        {
            this.cilindraje = cilindraje;
            this.velocidad = 0;
            nivelGasolina = 100;
        }

        public override void acelerar(int cuanto)
        { 
        base.acelerar(cuanto);
            nivelGasolina-=26;
            if (nivelGasolina < 0) nivelGasolina = 0;
            Console.WriteLine("Nivel de gasolina: " + nivelGasolina);

        }
        
        public void cilindrajeMoto()
        {
            Console.WriteLine("Cilindraje: " + cilindraje);
        }
        public void ObtenerNivelGaso()
        {
            Console.WriteLine("Nivel de gasolina: " + nivelGasolina);
     
        }

    }
}
