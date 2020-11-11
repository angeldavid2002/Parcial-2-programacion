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
        private readonly string FileNameContrato = "Contrato.txt";
        private string FileNameFiltrado;
        public ContratoRepositorio()
        {
        }
        public void Guardar(Contrato contrato)
        {
            FileStream file = new FileStream(FileNameContrato, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(contrato.tipoContrato + ";" +
                contrato.numeroIdentificacion + ";" +
                contrato.nombreContratista + ";" +
                contrato.fechaSuscripcion.ToString("dd/MM/yyyy") + ";" +
                contrato.valorContrato+ "");
            writer.Close();
            file.Close();
        }
        public List<Contrato> ConsultarTodos()
        {
            List<Contrato> contratos = new List<Contrato>();
            FileStream file = new FileStream(FileNameContrato, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;
            while ((linea = reader.ReadLine()) != null)
            {
                Contrato contrato = Map(linea);
                contratos.Add(contrato);
            }
            reader.Close();
            file.Close();
            return contratos;
        }
        private Contrato Map(string linea)
        {
            Contrato contrato= new Contrato();
            char delimiter = ';';
            string[] matrizaContrato = linea.Split(delimiter);
            contrato.tipoContrato = matrizaContrato[0];
            contrato.numeroIdentificacion = matrizaContrato[1];
            contrato.nombreContratista = matrizaContrato[2];
            contrato.fechaSuscripcion = Convert.ToDateTime(matrizaContrato[3]);
            contrato.valorContrato = Convert.ToDouble(matrizaContrato[4]);
            return contrato;
        }
        public List<Contrato> ConsultarFiltrado(string tipoContrato,DateTime fecha)
        {
            List<Contrato> contratosFiltrados;
            contratosFiltrados = (from C in ConsultarTodos()
                                 where C.tipoContrato.Equals(tipoContrato) && C.fechaSuscripcion.Equals(fecha)
                                 select C).ToList();
            return contratosFiltrados;
        }
        public void GuardarListaFiltrados(string tipoContrato, DateTime fecha)
        {
            FileNameFiltrado = tipoContrato+" "+fecha.ToString("ddMMyyyy")+".txt";
            List<Contrato> contratosFiltrados= ConsultarFiltrado(tipoContrato, fecha);
            foreach (Contrato item in contratosFiltrados)
            {
                GuardarFiltrados(item,FileNameFiltrado);
            }
        }
        public void GuardarFiltrados(Contrato contrato,string nombreArchivo)
        {
            FileStream file = new FileStream(nombreArchivo, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(contrato.tipoContrato + ";" +
                contrato.numeroIdentificacion + ";" +
                contrato.nombreContratista + ";" +
                contrato.fechaSuscripcion.ToString("dd/MM/yyyy") + ";" +
                contrato.valorContrato + "");
            writer.Close();
            file.Close();
        }
    }
}
