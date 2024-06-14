using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenMsmRecuperacionC_.servicios
{
    /// <summary>
    /// Contiene la logica de los metodos del servicio fichero
    /// msm - 140624
    /// </summary>
    internal class OperacionFicheroImplementacion : OperacionFicheroInterfaz
    {

        public void escribirLog(string texto)
        {
            string ruta = Program.nombreLog;

            StreamWriter sw = new StreamWriter(ruta, true);

            try
            {
                using (sw)
                {
                    sw.WriteLine(string.Concat(texto, "\n"));
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Se ha producido un error con el archivo log");
            }
        }
    }
}
