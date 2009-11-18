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

        public List<Articulo> ListarArticulos()
        {
            return (_context.Articulos.Where(articulo => !(articulo.BajaLogica.HasValue && articulo.BajaLogica.Value))).ToList();
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

        public bool AgregarArticulo(Articulo articuloGuardar)
        {
            try
            {
                _context.Articulos.InsertOnSubmit(articuloGuardar);
                _context.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;   
            }
        }

        public bool ActualizarArticulo(Articulo articuloActualizar)
        {
            try
            {
                var articulo = _context.Articulos.Where(art => art.idArticulo == articuloActualizar.idArticulo).Single();
                articulo.Precio = articuloActualizar.Precio;
                articulo.Descripcion = articuloActualizar.Descripcion;
                articulo.Stock = articuloActualizar.Stock;
                articulo.Codigo = articuloActualizar.Codigo;
                _context.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ActualizarStockArticulo(Articulo articuloActualizar)
        {
            try
            {
                var articulo = _context.Articulos.Where(art => art.idArticulo == articuloActualizar.idArticulo).Single();
                articulo.Stock = articuloActualizar.Stock;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Articulo DatosArticuloPorCodigo(int idArticulo)
        {
            return (_context.Articulos.Single(art => art.idArticulo == idArticulo));
        }

        public bool EliminarArticulo(int idArticulo)
        {
            try
            {
                var articulo = _context.Articulos.Where(art => art.idArticulo == idArticulo).Single();
                articulo.BajaLogica = true;
                _context.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Articulo> BuscadorPorCodigoArticulo(string codigoArticulo)
        {
            return _context.Articulos.Where(art => art.Codigo.Contains(codigoArticulo)).ToList();
        }

        public List<Articulo> BuscadorPorDescripcion(string descripcion)
        {
            return _context.Articulos.Where(art => art.Descripcion.Contains(descripcion)).ToList();
        }

        public List<Articulo> BuscadorPorCódigoColor(string codigoColor)
        {
            return _context.Articulos.Where(art => art.CodColor.Contains(codigoColor)).ToList();
        }

        public bool ReducirStock(int idArticulo, decimal cantidad)
        {
            try
            {
                var articulo = _context.Articulos.Where(art => art.idArticulo == idArticulo).Single();
                articulo.Stock -= cantidad;
                var egreso = new Egreso_Stock();
                egreso.idArticulo = articulo.idArticulo;
                egreso.FechaEgreso = DateTime.Now;
                egreso.Cantidad = cantidad;
                egreso.Motivo = "Remito";
                _context.Egreso_Stocks.InsertOnSubmit(egreso);
                _context.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
