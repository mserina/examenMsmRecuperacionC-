using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenMsmRecuperacionC_.utilidades
{
    /// <summary>
    /// Contiene metodos que se usaran a lo largo del programa
    /// msm - 140624
    /// </summary>
    internal class Utilidades
    {
        public static string nombreLog()
        {
            DateTime fechaHoy = DateTime.Now;
            string fecha = fechaHoy.ToString("ddMMyyyy");
            string nombreLog = string.Concat("C:\\Users\\csi23-mserina\\source\\repos\\examenMsmRecuperacionC#\\log-", fecha, ".txt");
            
            return nombreLog;
        }

        public static long idGenearatorV()
        {
            int numeroLista = Program.listaVehiculos.Count -1;
            long idNuevo = 0;
            
            if (Program.listaVehiculos.Count > 0)
            {
                idNuevo = Program.listaVehiculos[numeroLista].Id + 1;
            }
            else
            {
                idNuevo = 1;    
            }

            return idNuevo;
        }

        public static long idGenearatorP()
        {
            int numeroLista = Program.listaPropietarios.Count - 1;
            long idNuevo = 0;

            if (Program.listaPropietarios.Count > 0)
            {
                idNuevo = Program.listaPropietarios[numeroLista].Id + 1;
            }
            else
            {
                idNuevo = 1;
            }

            return idNuevo;
        }
    }
}


