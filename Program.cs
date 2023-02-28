using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnEmpleado
{
    /// <summary>
    /// 22/02/2023
    /// Jaider Andres Oquendo Zapata
    /// programa que representa un empleado. tiene como atributos su nombre y su sueldo. con métodos: para la carga de datos
    /// otro para imprimir sus datos y por último uno que imprime un mensaje si debe pagar impuestos.
    /// </summary>
    internal class Program
    {
        //Atributos
        string Nombre;
        double Sueldo;

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a el programa empleado");
            //instancia la clase, para invocar los metodos.
            Program empleado = new Program();
            empleado.Datos_Atributos();
            empleado.ImprimirDatos();
            empleado.ImprimirMensaje();


            Console.ReadKey();
        }
        //Metodos.

        //Metodo para la carga de datos.
        public void Datos_Atributos()
        {
            Console.WriteLine("Por favor ingrese el nombre:");
            Nombre= Console.ReadLine();
            Console.WriteLine("Por favor ingrese el sueldo:");
            Sueldo = Convert.ToDouble( Console.ReadLine() );
        }
        //Metodo para imprimir sus datos.
        public void ImprimirDatos()
        {
            Console.WriteLine("Datos:");
            Console.WriteLine("El empleado: " + Nombre + " posee un sueldo de: " + Sueldo);
        }
        //Metodo que imprime un mensaje si el empleado debe pagar impuestos.
        public void ImprimirMensaje()
        {
            Console.WriteLine("Es decir que:");
            if (Sueldo>3000)
            {
                Console.WriteLine( "El empleado SI debe pagar impuestos");
            }
            else
            {
                Console.WriteLine("El empleado NO debe pagar impuestos");
            }
        }
    }
}
