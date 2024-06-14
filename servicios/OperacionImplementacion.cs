using examenMsmRecuperacionC_.dtos;
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
    internal class OperacionImplementacion : OperacionInterfaz
    {
        
        public void numeroHistorico()
        {
            DateTime fecha = DateTime.Now;
            int numeroCoches = 0;

            foreach (VehiculosDto veh in Program.listaVehiculos)
            {
                int fechaDiferencia = fecha.Year - veh.FchMatriculacion.Year;

                if (fechaDiferencia > 25)
                {
                    numeroCoches++;
                }
            }

            if(numeroCoches >= 1)
            {
                Console.WriteLine(string.Concat("N. Historicos:",numeroCoches));
            }
        }

        public void altaNuevoPropietario()
        {
            bool cerrarBucle = false;
            PropietariosDto propietarioNuevo = new PropietariosDto();
            propietarioNuevo.Id = utilidades.Utilidades.idGenearatorP();

            while (!cerrarBucle)
            {
                Console.WriteLine("Inserte dni");
                string dni = Console.ReadLine();
                if (dni.Length == 9)
                {
                    cerrarBucle = true;
                    propietarioNuevo.Dni = dni;
                }
                else
                {
                    Console.WriteLine("El formato es incorrecto, vuelva a escribirlo");
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine(propietarioNuevo.ToString());
            Console.WriteLine(" ");

        }
    }
}
