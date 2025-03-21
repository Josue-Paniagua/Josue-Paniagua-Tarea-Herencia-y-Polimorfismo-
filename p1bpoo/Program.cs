
using System.Net.NetworkInformation;
using p1bpoo.MisClases;

Vehiculo miCarrito = new Vehiculo(2026, "Azul", "Alfa Romeo");

Vehiculo elOtro = new Vehiculo(2000, "Rojo", "DELOREAN");

Console.WriteLine("\n*Esta parte es del carro electrico*");
CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");
miBYD.InformacionVehiculo();
miBYD.cargarBateria();
Console.WriteLine("\nEl nivel de bateria es: {0}", miBYD.NivelBateria());

Console.WriteLine("\n*Esta parte es del camion*");
Camion micamion = new Camion(2026, "Verde", "Volvo");
micamion.InformacionVehiculo();
micamion.cargaTOTAL(1000);
micamion.CargarGaso(0);

Console.WriteLine("\n*Esta parte es del carro de combustion* ");
CarroCombus micarroB = new CarroCombus(2025, "AZUL", "hilux", 400);
micarroB.InformacionVehiculo();
micarroB.acelerar(100);
micarroB.frenar(55);
micarroB.InformacionCombustible();

Console.WriteLine("\n*Esta parte es del la moto* ");
moto mimoto = new moto(2015, "negro", "honda", 500);
mimoto.InformacionVehiculo();
mimoto.acelerar(60);
mimoto.cilindrajeMoto();

