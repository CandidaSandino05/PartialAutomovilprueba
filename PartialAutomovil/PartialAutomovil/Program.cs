using PartialAutomovil;
using System.Drawing;
using System.Security;

partial class Programs
{
    static void Main(string[] args) 
    {
        //Integramos una instancia para la informacion de los vehiculos y poder utilizar los metodos 
        //Mostramos el vehiculo ingresado y sus referencias 

        Vehiculo Auto = new Vehiculo( "Toyota", "HSD3490", "HILUX", "Gris", 80, 30,true );
        Console.WriteLine("Marca: {0}", Auto.marca);
        Console.WriteLine("Placa: {0}", Auto.placa);
        Console.WriteLine("Capacidad Del Tanque de Combustible: {0}", Auto.capacidadtanqueCombustible);

        //Implementamos el metodo creado en la primer clase parcial 
        //Indicar el numero de kilometros a conducir (50 y 300)

        Auto.Conducir(50);
        Auto.Conducir(300);

        //Mandamos a llamar el metodo para poder llenar nuestro tanque de combustible 

        Auto.RestablecerCantCombustible(80);


        //Mostrarle al usuario el nivel de combustible restante luego de declarar la distancia recorrida

        Console.WriteLine("El nivel de Combustible Restante es de: {0} Litros.", Auto.nivelcombustible);

    }



}