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
            try
            {
                _context.Egreso_Stocks.InsertOnSubmit(articuloEgresoStock);
                _context.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<String> ListadoMotivosEgreso()
        {
            return _context.Egreso_Motivos.Select(egre => egre.Descripcion).ToList();
        }
    }
}
