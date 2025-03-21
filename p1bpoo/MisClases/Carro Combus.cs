namespace p1bpoo.MisClases
{
    internal class CarroCombus : Vehiculo
    {
        private int gasolina;
        private int nivelAceite;
        private int potencia;

        public CarroCombus(int anio, string elColor, string elModelo, int potencia) : base(anio, elColor, elModelo)
        {
            gasolina = 100;
            nivelAceite = 100;
            this.potencia = potencia;
        }

        public int Gasolina
        {
            get { return gasolina; }
            set
            {
                if (value >= 0) 
                    gasolina = value;
                else
                    gasolina = 0; 
            }
        }

        public int NivelAceite
        {
            get { return nivelAceite; }
            set
            {
                if (value >= 0)
                    nivelAceite = value;
                else
                    nivelAceite = 0;  
            }
        }

        public int Potencia
        {
            get { return potencia; }
            set
            {
                if (value >= 0)
                    potencia = value;
                else
                    potencia = 0;
            }
        }

        
        public override void frenar(int cuanto)
        {
            base.frenar(cuanto);
            Gasolina--; 
            if (Gasolina < 0) Gasolina = 0;  
        }

        // Método adicional
        public void InformacionCombustible()
        {
            Console.WriteLine("Gasolina: " + Gasolina);
            Console.WriteLine("Nivel de Aceite: " + NivelAceite);
        }
    }
}
