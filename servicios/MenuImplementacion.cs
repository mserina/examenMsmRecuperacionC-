using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenMsmRecuperacionC_.servicios
{
    /// <summary>
    /// Contiene la logica de los metodos del servicio operacion
    /// msm - 140624
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {

        public int mostrarMenuPrincipal()
        {
            int opcionSeleccionada;

            Console.WriteLine("###########");
            Console.WriteLine("0[] Cerrar Menu");
            Console.WriteLine("1[] Alta nuevo propietario");
            Console.WriteLine("2[] Numero historico");
            Console.WriteLine(" ");

            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());

            return opcionSeleccionada;

        }
    }
}
