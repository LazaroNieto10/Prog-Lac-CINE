using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using DataCine.Factory;
using DataCine.Clases;

namespace WebApiAppCine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CineController : ControllerBase
    {
        private IServicios Servicio;

        public CineController()
        {
            Servicio = new Servicios();
        }

        [HttpGet("/TicketMes")]
        public IActionResult GetTicketMes(string NombreSP, string mes)
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = Servicio.TicketMes(NombreSP, mes);
                return Ok(tabla);
            }
            catch (Exception) { return StatusCode(500, "Error, datos no encontrados"); }
        }

        [HttpGet("/TopPelis")]
        public IActionResult GetTopPelis(string NombreSP, int anio)
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = Servicio.Top3(NombreSP, anio);
                return Ok(tabla);
            }
            catch (Exception) { return StatusCode(500, "Error, datos no encontrados"); }
        }


        [HttpGet("/Vista")]
        public IActionResult GetVista(string Consulta)
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = Servicio.Vista(Consulta);
                return Ok(tabla);
            }
            catch (Exception) { return StatusCode(500, "Error, datos no encontrados"); }
        }

        [HttpGet("/FormaPago")]
        public IActionResult GetFormaPago(string NombreSP, int eleccion)
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = Servicio.FormasPagoMesOAnio(NombreSP, eleccion);
                return Ok(tabla);
            }
            catch (Exception) { return StatusCode(500, "Error, datos no encontrados"); }
        }

        [HttpGet("/AsientoDisp")]
        public IActionResult GetAsientosDisponibles(string NombreSP, int funcion)
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = Servicio.AsientosDisponibles(NombreSP, funcion);
                return Ok(tabla);
            }
            catch (Exception) { return StatusCode(500, "Error, datos no encontrados"); }
        }

        [HttpGet("/MuestraFecha")]
        public IActionResult GetMuestraPorFecha(string NombreSP, DateTime fecha, DateTime fecha2)
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = Servicio.MostrarPorFecha(NombreSP, fecha, fecha2);
                return Ok(tabla);
            }
            catch (Exception) { return StatusCode(500, "Error, datos no encontrados"); }
        }

        [HttpPost("/MuestraFecha")]
        public IActionResult GetInsertComprobante(Comprobante oComprobante, string Comprobante_SP, string Detalle_SP, string Ticket_SP)
        {
            try
            {
                if (oComprobante == null)
                {
                    return BadRequest("Datos de presupuesto incorrectos!");
                }

                return Ok(Servicio.CrearComprobante(oComprobante,Comprobante_SP,Detalle_SP,Ticket_SP));
            }
            catch (Exception)
            {
                return StatusCode(500, "Error interno! Intente luego");
            }
        }

        [HttpGet("/CantDetalles")]
        public IActionResult GetCantidadDetalles(string NombreSP, string NomParam)
        {
            int cantDetalles = 0;
            try
            {
                cantDetalles = Servicio.ObtenerCantDet(NombreSP,NomParam);
                return Ok(cantDetalles);
            }
            catch (Exception) { return StatusCode(500, "Error, datos no encontrados"); }
        }
    }
}
