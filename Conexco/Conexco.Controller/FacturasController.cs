using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Conexco.Model;

namespace Conexco.Controller
{
    public class FacturasController
    {
        private ConexcoDataClassesDataContext _context;

        public FacturasController()
        {
            _context = new ConexcoDataClassesDataContext();
        }

        public bool AgregarFactura(Factura factura)
        {
            try
            {
                _context.Facturas.InsertOnSubmit(factura);
                _context.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Documentos_Tipo> ListarDocumentosTipo()
        {
           return _context.Documentos_Tipos.Select(dt => dt).ToList();
        }

        public List<Documentos_Estado> ListarDocumentosEstado()
        {
            return _context.Documentos_Estados.Select(de => de).ToList();
        }

        public DataSet ListarFacturas(string estadoFactura)
        {
            if (!String.IsNullOrEmpty(estadoFactura))
            {
                var idEstado =
                    _context.Documentos_Estados.Where(est => est.Descripcion == estadoFactura).Select(est => est.idEstado)
                        .First();

                return ListaFacturasToDataSet(_context.Facturas.Where(factura => factura.idEstado == idEstado).OrderByDescending(fac => fac.FechaVto).ToList());
            }
            
            return ListaFacturasToDataSet(_context.Facturas.Select(fact => fact).ToList());
        }

        public List<Factura> ListarFacturasList(string estadoFactura)
        {
            if (!String.IsNullOrEmpty(estadoFactura))
            {
                var idEstado =
                    _context.Documentos_Estados.Where(est => est.Descripcion == estadoFactura).Select(est => est.idEstado)
                        .First();

                return _context.Facturas.Where(factura => factura.idEstado == idEstado).OrderByDescending(fac => fac.FechaVto).ToList();
            }

            return _context.Facturas.Select(fact => fact).ToList();
        }

        public DataSet ListaFacturasToDataSet(List<Factura> listadoFacturas)
        {
            var dsFacturas = new DataSet();
            dsFacturas.Tables.Add();
            dsFacturas.Tables[0].Columns.Add("IdFactura", typeof(string));
            dsFacturas.Tables[0].Columns.Add("IdCliente", typeof(string));
            dsFacturas.Tables[0].Columns.Add("N° Factura", typeof(string));
            dsFacturas.Tables[0].Columns.Add("Fecha", typeof(DateTime));
            dsFacturas.Tables[0].Columns.Add("Vencimiento", typeof(DateTime));
            dsFacturas.Tables[0].Columns.Add("Cliente", typeof (string));
            dsFacturas.Tables[0].Columns.Add("Total", typeof (string));
            dsFacturas.Tables[0].Columns.Add("Estado", typeof (string));

            foreach (var factura in listadoFacturas)
            {
                dsFacturas.Tables[0].Rows.Add(factura.idFactura, factura.idCliente, factura.Numero, factura.FechaEmision.Date, factura.FechaVto.HasValue ? factura.FechaVto.Value.Date : DateTime.MinValue.Date, this.DatosClientePorFactura(factura).Codigo, factura.Total,
                                              factura.Documentos_Estado.Descripcion);
            }

            return dsFacturas;
        }

        public DataSet ListarFacturasPorCriterio(string estadoFactura, string criterio, string valor)
        {
            var facturasEncontradas = new List<Factura>();
            var facturasEstados = this.ListarFacturasList(estadoFactura);

            valor = valor.ToLower();

            try
            {
                switch (criterio)
                {
                    case "Código de Cliente":
                        facturasEncontradas =
                            (facturasEstados.Where(
                                fact =>
                                !(fact.BajaLogica.HasValue && fact.BajaLogica.Value) && this.DatosClientePorFactura(fact).Codigo.ToLower().Contains(valor)).
                                OrderBy(fact => fact.FechaVto)).ToList();
                        break;
                    case "Nombre o Razón Social":
                        facturasEncontradas =
                            (facturasEstados.Where(
                                fact =>
                                !(fact.BajaLogica.HasValue && fact.BajaLogica.Value) &&
                                ((this.DatosClientePorFactura(fact).Nombre.ToLower().Contains(valor) || this.DatosClientePorFactura(fact).Apellido.ToLower().Contains(valor) ||
                                  this.DatosClientePorFactura(fact).RazonSocial.ToLower().Contains(valor)))).OrderBy(fact => fact.FechaVto)).ToList();
                        break;
                    case "CUIT":
                        facturasEncontradas =
                            (facturasEstados.Where(
                                fact => !(fact.BajaLogica.HasValue && fact.BajaLogica.Value) && (this.DatosClientePorFactura(fact).CUIT.Contains(valor)))
                                .OrderBy(fact => fact.FechaVto)).ToList();
                        break;
                    default:
                        facturasEncontradas = ListarFacturasList(estadoFactura);
                        break;
                }
            }
            catch (Exception)
            {
                facturasEncontradas = new List<Factura>();
            }
            return this.ListaFacturasToDataSet(facturasEncontradas);
        }

        private Cliente DatosClientePorFactura(Factura fact)
        {
            return _context.Clientes.FirstOrDefault(c => c.idCliente == fact.idCliente);
        }

        public Factura DatosFactura(int idFactura)
        {
            return _context.Facturas.Where(fact => fact.idFactura == idFactura).First();
        }

        public List<Documentos_Estado> EstadosFactura()
        {
            return _context.Documentos_Estados.Select(estado => estado).ToList();
        }

        public bool ActualizarFactura(int idFactura, string estado)
        {
            try
            {
                var estadoFactura =
                    _context.Documentos_Estados.Where(estados => estados.Descripcion == estado).First();
                var factura = _context.Facturas.Where(fact => fact.idFactura == idFactura).First();
                factura.Documentos_Estado = estadoFactura;
                _context.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
