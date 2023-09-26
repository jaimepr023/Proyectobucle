using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectobucle.Servidores
{
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Clase que implementa la interfaz del menu
        ///  250923-jpr
        /// </summary>
        public void mostrarMensajeBienvenida()
        {
            string mensaje = "Bienvenido CSI1";
            Console.WriteLine(mensaje);
        }

        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;
            Console.WriteLine("###################################");
            Console.WriteLine("0. Cerrar aplicacion");
            Console.WriteLine("1. Darse de alta");
            Console.WriteLine("2. Ingresar dinero");
            Console.WriteLine("3. Sacar dinero");
            Console.WriteLine("4. Transferir dinero");
            Console.WriteLine("5. Historial de opciones");
            Console.WriteLine("###################################");
            Console.WriteLine("Seleccione una opcion");

           opcionIntroducida = Console.ReadKey(true).KeyChar-('0'); 
            //keychar es un solo caracter, funcion= habilitar la consola

            return opcionIntroducida;
            //devuelve un entero 
        }
    }
}
