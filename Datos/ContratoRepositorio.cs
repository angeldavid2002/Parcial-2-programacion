using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.IO;
namespace Datos
{
    public class ContratoRepositorio
    {
        private readonly string FileName = "Contrato.txt";
        public ContratoRepositorio()
        {
        }
        public void Guardar(Contrato contrato)
        {
            FileStream file = new FileStream(FileName, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(contrato.tipoContrato + ";" +
                contrato.numeroIdentificacion + ";" +
                contrato.nombreContratista + ";" +
                contrato.fechaSuscripcion.ToString("dd/MM/yyyy") + ";" +
                contrato.valorContrato+ "");
            writer.Close();
            file.Close();
        }

    }
}
