using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Conexco.Model;

namespace Conexco.Controller
{
    public class PresupuestoController
    {
        private ConexcoDataClassesDataContext _context;

        public PresupuestoController()
        {
            _context = new ConexcoDataClassesDataContext();
        }

        public bool AgregarPresupuesto(Presupuesto presupuesto)
        {
            try
            {
                _context.Presupuestos.InsertOnSubmit(presupuesto);
                _context.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Documentos_Estado> ListarDocumentosEstado()
        {
            return _context.Documentos_Estados.Select(est => est).ToList();
        }
    }
}
