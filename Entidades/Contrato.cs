using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contrato
    {
        public Contrato()
        {
        }

        public Contrato(string tipoContrato, string numeroIdentificacion, string nombreContratista, DateTime fechaSuscripcion, double valorContrato)
        {
            this.tipoContrato = tipoContrato;
            this.numeroIdentificacion = numeroIdentificacion;
            this.nombreContratista = nombreContratista;
            this.fechaSuscripcion = fechaSuscripcion;
            this.valorContrato = valorContrato;
        }

        public string tipoContrato { get; set; }
        public string numeroIdentificacion { get; set; }
        public string nombreContratista { get; set; }
        public DateTime fechaSuscripcion { get; set; }
        public double valorContrato { get; set; }

    }
}
