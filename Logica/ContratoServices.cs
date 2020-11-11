using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
namespace Logica
{
    public class ContratoServices
    {
        static ContratoRepositorio contratoRepositorio;
        public ContratoServices()
        {
            contratoRepositorio = new ContratoRepositorio();
        }
        public string Guardar(Contrato contrato)
        {
            try
            {
                contratoRepositorio.Guardar(contrato);
                return "se guardo exitosamente";
            }
            catch (Exception e)
            {

                return "error de la aplicacion: " + (e.Message);
            }
        }

    }
}
