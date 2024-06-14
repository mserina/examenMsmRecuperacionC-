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
    internal interface OperacionFicheroInterfaz
    {
        /// <summary>
        /// Escribe en el fichero log
        /// </summary>
        /// <param name="texto">el texto que va a escribir en el log</param>
        public void escribirLog(string texto);

        public void cargaInical();
    }
}
