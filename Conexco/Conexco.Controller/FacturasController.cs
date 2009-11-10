using System;
using System.Collections.Generic;
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
    }
}
