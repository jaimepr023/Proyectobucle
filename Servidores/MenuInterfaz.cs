using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectobucle.Servidores
{
    /// <summary>
    /// Interfaz con la relacion de metodos de la funcionalidad menu
    ///250923-jpr
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el mensaje de bienvenida al cajero.
        /// 260923-jpr
        /// </summary>
       public void mostrarMensajeBienvenida();

        /// <summary>
        /// Metodo que muestra el menu y recoge la seleccion del usuario 
        ///  260923-jpr
        /// </summary>
        /// <returns>un entero con la posicion seleccionada</returns>
        public int mostrarMenuYSeleccion();
       
    }
}
