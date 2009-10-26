using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Conexco.Model;

namespace Conexco.Controller
{
    public class FiscalesController
    {
        private Conexco.Model.ConexcoDataClassesDataContext _context;

        public FiscalesController()
        {
            _context = new ConexcoDataClassesDataContext();
        }

        public List<CondicionIVA> ListarCondicionIVA()
        {
            return _context.CondicionIVAs.Select(cond => cond).ToList();
        }

    }
}
