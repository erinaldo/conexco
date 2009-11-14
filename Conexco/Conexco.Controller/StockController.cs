using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Conexco.Model;

namespace Conexco.Controller
{
    public class StockController
    {
        private ConexcoDataClassesDataContext _context;

        public StockController()
        {
            _context = new ConexcoDataClassesDataContext();
        }

        public bool EgresoStockArticulo(Egreso_Stock articuloEgresoStock)
        {
            return true;
        }
    }
}
