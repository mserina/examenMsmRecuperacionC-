using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace examenMsmRecuperacionC_.dtos
{
    /// <summary>
    /// Contiene los atributos y metodos de la clase Vehiculo 
    /// msm - 140624
    /// </summary>
    internal class VehiculosDto
    {
        long id;
        string matricula = "aaa";
        DateTime fchMatriculacion = new DateTime();

        public long Id { get => id; set => id = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public DateTime FchMatriculacion { get => fchMatriculacion; set => fchMatriculacion = value; }

        
    }
}
