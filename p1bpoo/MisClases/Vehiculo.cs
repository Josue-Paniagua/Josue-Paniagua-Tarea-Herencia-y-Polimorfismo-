using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }

        private int velocidad = 0;



        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("Color: {0}", this.Color);
            Console.WriteLine("Modelo: {0}", this.Modelo);
            Console.WriteLine("Año: {0}", this.Year);
        }
        public virtual void acelerar(int cuanto)
        {
            velocidad += cuanto;
            Console.WriteLine("vas a {0} KMS / Hora", velocidad);
        }
        public virtual void frenar(int cuanto)
        {
            velocidad -= cuanto;
            if (velocidad < 0) velocidad = 0;
            Console.WriteLine("vas a {0} KMS / Hora", velocidad);
        }
        public virtual void encender(bool encendido = true)
        {
            if (encendido)
            {
                Console.WriteLine("Vehiculo encendido");
            }
            else
            {
                Console.WriteLine("Vehiculo apagado");
            }
        }
        public virtual void CargarGaso(int gasolina)
        { 
                Console.WriteLine("Cargando gasolina");
            
        }

    }
}
