using System.Collections.Generic;
using System.Linq;
using Conexco.Model;

namespace Conexco.Controller
{
    public class ArticulosController
    {
        private ConexcoDataClassesDataContext _context;

        public ArticulosController()
        {
            _context = new ConexcoDataClassesDataContext();
        }

        public bool IngresoStock(Articulos_Stock stock)
        {
            _context.Articulos_Stocks.InsertOnSubmit(stock);
            _context.SubmitChanges();
            return true;
        }

        public List<Articulo> ListarArticulos()
        {
            return (_context.Articulos.Select(art => art)).ToList();
        }
    }
}
