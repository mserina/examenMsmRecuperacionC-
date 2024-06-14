using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenMsmRecuperacionC_.dtos
{
    /// <summary>
    /// Contiene los atributos y metodos de la clase Vehiculo
    /// msm - 140624
    /// </summary>
    internal class PropietariosDto
    {
        long id;
        string dni = "aaaa";
        DateTime fchaCompra = DateTime.Now;
        string matricula = "aaa";
        bool esHistorico = false;

       

        public long Id { get => id; set => id = value; }
        public string Dni { get => dni; set => dni = value; }
        public DateTime FchaCompra { get => fchaCompra; set => fchaCompra = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public bool EsHistorico { get => esHistorico; set => esHistorico = value; }

        public PropietariosDto(long id, string dni, DateTime fchaCompra, string matricula, bool esHistorico)
        {
            this.id = id;
            this.dni = dni;
            this.fchaCompra = fchaCompra;
            this.matricula = matricula;
            this.esHistorico = esHistorico;
        }

        public PropietariosDto()
        {
           
        }

        override
        public string ToString()
        {
            string texto = string.Concat("Nuevo Propietario: ", id,"-",dni);

            return texto;
        }

    }
}
