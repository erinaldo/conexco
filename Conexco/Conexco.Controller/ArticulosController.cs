using System;
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

        public List<string> ListarCodigoYColorArticulos()
        {
            return (_context.Articulos.Select(art => art.Codigo + "-" + art.CodColor)).ToList();
        }

        public List<string> ListarDescripcionArticulos()
        {
            return (_context.Articulos.Select(art => art.Descripcion)).ToList();
        }

        public Articulo DatosArticuloPorCodigoYColor(string codigoYColor)
        {
            var arrayCodColor = codigoYColor.Split('-');
            var codigo = arrayCodColor[0];
            var codColor = arrayCodColor[1];

            return (_context.Articulos.Single(art => art.Codigo == codigo && art.CodColor == codColor));
        }

        public Articulo DatosArticuloPorDescripcion(string descripcion)
        {
            return (_context.Articulos.Single(art => art.Descripcion == descripcion));
        }

        public Articulos_Color DatosArticuloColorPorCodigoColor(string codColor)
        {
            return (_context.Articulos_Colors.Single(col => col.Codigo == codColor));
        }

        public Articulos_Color DatosArticuloColor(int idColor)
        {
            return (_context.Articulos_Colors.Single(col => col.idColor == idColor));
        }
    }
}
