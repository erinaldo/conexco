using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Conexco.Model;

namespace Conexco.Controller
{
    public class RemitosController
    {
        private ConexcoDataClassesDataContext _context;

        public RemitosController()
        {
            _context = new ConexcoDataClassesDataContext();
        }

        public bool AgregarRemito(Remito remito)
        {
            try
            {
                _context.Remitos.InsertOnSubmit(remito);
                _context.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Documentos_Estado> ListarDocumentosEstado()
        {
            return _context.Documentos_Estados.Select(de => de).ToList();
        }
    }
}
