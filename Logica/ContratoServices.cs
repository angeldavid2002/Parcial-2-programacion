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
        public class RespuestaContrato
        {
            public List<Contrato> contratos { get; set; }
            public bool listaVacia { get; set; }
            public string mensaje { get; set; }
            public RespuestaContrato(List<Contrato> contratos)
            {
                this.contratos = contratos;
                this.listaVacia = false;
                this.mensaje = "lectura exitosa";
            }
            public RespuestaContrato(string mensaje)
            {
                this.listaVacia = true;
                this.mensaje = mensaje;
            }
        }
        public RespuestaContrato ConsultarTodos()
        {
            RespuestaContrato respuestaContrato;
            try
            {
                if (contratoRepositorio.ConsultarTodos().Any())
                {
                    List<Contrato> contratos = contratoRepositorio.ConsultarTodos();
                    respuestaContrato = new RespuestaContrato(contratos);
                    return respuestaContrato;
                }
                else
                {
                    return respuestaContrato = new RespuestaContrato("no se encontraron elementos");
                }
            }
            catch (Exception e)
            {

                return respuestaContrato = new RespuestaContrato("se produjo un error: " + e.Message);
            }
        }
        public RespuestaContrato ConsultarFiltrado(string tipoContrato, DateTime fecha)
        {
            RespuestaContrato respuestaContrato;
            try
            {
                if (contratoRepositorio.ConsultarTodos().Any())
                {
                    List<Contrato> contratos = contratoRepositorio.ConsultarFiltrado(tipoContrato,fecha);
                    respuestaContrato = new RespuestaContrato(contratos);
                    return respuestaContrato;
                }
                else
                {
                    return respuestaContrato = new RespuestaContrato("no se encontraron elementos");
                }
            }
            catch (Exception e)
            {

                return respuestaContrato = new RespuestaContrato("se produjo un error: " + e.Message);
            }
        }
        public string GuardarFiltrado(string tipoContrato, DateTime fecha)
        {
            try
            {
                contratoRepositorio.GuardarListaFiltrados(tipoContrato,fecha);
                return "se guardo exitosamente";
            }
            catch (Exception e)
            {

                return "error de la aplicacion: " + (e.Message);
            }
        }
    }
}
