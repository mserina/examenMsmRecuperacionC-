using examenMsmRecuperacionC_.dtos;
using examenMsmRecuperacionC_.servicios;

namespace examenMsmRecuperacionC_
{
    /// <summary>
    /// Es la clase principal del programa
    /// msm - 140624
    /// </summary>
    class Program
    {
        public static string texto;
        public static string rutaFichero = "C:\\Users\\csi23-mserina\\source\\repos\\examenMsmRecuperacionC#\\datosIniciales.txt";
        public static string rutaFicheroLog = utilidades.Utilidades.nombreLog();
        public static List<VehiculosDto> listaVehiculos = new List<VehiculosDto>();
        public static List<PropietariosDto> listaPropietarios = new List<PropietariosDto>();
        /// <summary>
        /// Metodo que contiene el procedimiento de la aplicacion
        /// msm - 140624
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
           

            MenuInterfaz mi = new MenuImplementacion();
            OperacionFicheroInterfaz of = new OperacionFicheroImplementacion();
            OperacionInterfaz op = new OperacionImplementacion();

            if (File.Exists(rutaFichero))
            {
                of.cargaInical();
            }
            int opcionSeleccionada;
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                try
                {
                    opcionSeleccionada = mi.mostrarMenuPrincipal();

                    switch (opcionSeleccionada)
                    {
                        case 0:
                            texto = "Se ha cerrado aplicacion";
                            of.escribirLog(texto);
                            cerrarMenu = true;
                            break;
                        case 1:
                            texto = "Se ha seleccionado alta nuevo propietario";
                            of.escribirLog(texto);
                            op.altaNuevoPropietario();
                            break;
                        case 2:
                            texto = "Se ha seleccionado numero de historicos";
                            of.escribirLog(texto);
                            op.numeroHistorico();
                            break;
                        default:
                            Console.WriteLine("Esa opcion no existe");
                            break;
                    }
                }
                catch (Exception e)
                {
                    texto = string.Concat("ERROR[]: ", e.Message);
                    of.escribirLog(texto);
                }
            }
        }
    }
}