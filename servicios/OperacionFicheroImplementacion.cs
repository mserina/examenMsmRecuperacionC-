using examenMsmRecuperacionC_.dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
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
            string ruta = Program.rutaFicheroLog;

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

        public void cargaInical()
        {
            string rutaFichero = Program.rutaFichero;
            StreamReader sr = new StreamReader(rutaFichero);
            string lineas;
            int fechaDiferencia;
            DateTime fechaHoy = DateTime.Now;

            try
            {
                while ((lineas = sr.ReadLine()) != null)
                {
                    VehiculosDto vehiculo = new VehiculosDto();
                    string[] campo = lineas.Split(":");
                    vehiculo.Id = utilidades.Utilidades.idGenearatorV();
                    vehiculo.Matricula = campo[0];
                    vehiculo.FchMatriculacion = Convert.ToDateTime(campo[1]);


                    Program.listaVehiculos.Add(vehiculo);

                    long id = utilidades.Utilidades.idGenearatorP();
                    string dni = campo[2];
                    DateTime fechaCompra = Convert.ToDateTime(campo[3]);
                    string matricula = campo[0];
                    fechaDiferencia = fechaHoy.Year - vehiculo.FchMatriculacion.Year;
                    bool esHistorico = false;
                    if (fechaDiferencia > 25)
                    {
                        esHistorico = true;
                    }

                    PropietariosDto propietarios = new PropietariosDto(id, dni, fechaCompra, matricula, esHistorico);

                    Program.listaPropietarios.Add(propietarios);



                }
            }
            catch (IOException)
            {
                Program.texto = "Se ha cerrado aplicacion";
                escribirLog(Program.texto);
            }
        }
    }
}
