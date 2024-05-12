using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PartialAutomovil
{
    partial class Vehiculo
    {
        public string marca { get; set; }
        public string placa { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public int capacidadtanqueCombustible { get; set; }
        public int rendCombustible { get; set; }
        public int nivelcombustible { get; set; }

        public Vehiculo(string Marca, string Placa, string Modelo, string Color, int CapacidadDeTanqueCombustible, int RendimientoDeCombustible, bool v) 
        {
            this.marca = Marca;
            this.placa = Placa; 
            this.modelo = Modelo;
            this.color = Color;
            this.capacidadtanqueCombustible = CapacidadDeTanqueCombustible;
            this.rendCombustible = RendimientoDeCombustible;
            this.nivelcombustible = 0;
            
        }

        public bool CombustibleSuficiente(int Distancia) 
        {
            return nivelcombustible >= Distancia / rendCombustible;
          
        }

        public void Conducir(int Distancia)
        {
            try
            {
                if (CombustibleSuficiente(Distancia))
                {
                    nivelcombustible -= Distancia / rendCombustible;
                    Console.WriteLine("{0} Kilometros Conducidos, Su nivel de combustible restante es: {1} Litros.", Distancia, nivelcombustible);

                }
                else
                {
                    Console.WriteLine("No posee combustible suficiente para conducir {0} Kilometros.", Distancia);
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: Su rendimiento de combustible es cero (0).");


            }



        }


        public void RestablecerCantCombustible(int Cantidad) 
        {
            if (nivelcombustible + Cantidad <= capacidadtanqueCombustible)
            {
                nivelcombustible += Cantidad;
                Console.WriteLine("Se añadio {0} Litros de Combustible," +
                                 " El nuevo nivel de Combustible es: {1} Litros.", Cantidad, nivelcombustible);

            }
            else 
            {
                Console.WriteLine("No puede añadir esa cantidad de combustible , excede los limites de capacidad del tanque.");

            }
        
        }
    }
}
