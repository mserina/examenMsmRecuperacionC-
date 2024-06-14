using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenMsmRecuperacionC_.servicios
{
    /// <summary>
    /// Contiene la cabezera de los metodos del servicio operacion
    /// msm - 140624
    /// </summary>
    internal interface OperacionInterfaz
    {
        /// <summary>
        /// Muestra el numero de coches historicos
        /// msm - 140624
        /// </summary>
        public void numeroHistorico();

        /// <summary>
        /// Da de alta los nuevos propietarios
        /// msm - 140624
        /// </summary>
        public void altaNuevoPropietario();
    }
}
