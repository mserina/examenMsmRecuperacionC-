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
        public static string nombreLog = utilidades.Utilidades.nombreLog();
        public static List<VehiculosDto> listaVehiculos = new List<VehiculosDto>();
        public static List<PropietariosDto> listaPropietarios = new List<PropietariosDto>();
        /// <summary>
        /// Metodo que contiene el procedimiento de la aplicacion
        /// msm - 140624
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            VehiculosDto veh = new VehiculosDto();
            long id = utilidades.Utilidades.idGenearatorV();
            veh.Matricula = "123";
            veh.FchMatriculacion = Convert.ToDateTime("12-02-1980");

            listaVehiculos.Add(veh);

            foreach (VehiculosDto vehi in Program.listaVehiculos)
            {
                Console.WriteLine(vehi.Matricula);
            }

            MenuInterfaz mi = new MenuImplementacion();
            OperacionFicheroInterfaz of = new OperacionFicheroImplementacion();
            OperacionInterfaz op = new OperacionImplementacion();

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