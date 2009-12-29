using System;
using System.Collections.Generic;
using System.Data;
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
            return (_context.Articulos.Where(articulo => !(articulo.BajaLogica.HasValue && articulo.BajaLogica.Value)).OrderBy(articulo => articulo.Codigo)).ToList();
        }

        public List<string> ListarCodigoYColorArticulos()
        {
            var listaCodigoYColor = (_context.Articulos.Where(art => !(art.BajaLogica.HasValue && art.BajaLogica.Value))
                .Select(art => art.Codigo + "-" + art.CodColor)).ToList();
            listaCodigoYColor.Sort();
            return listaCodigoYColor;
        }

        public List<string> ListarDescripcionArticulos()
        {
            var listaDescripcion = (_context.Articulos.Where(art => !(art.BajaLogica.HasValue && art.BajaLogica.Value)).Select(art => art.Descripcion)).ToList();
            listaDescripcion.Sort();
            return listaDescripcion;
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
                articuloGuardar.BajaLogica = false;
                _context.Articulos.InsertOnSubmit(articuloGuardar);
                _context.SubmitChanges();
                return true;
            }
            catch (Exception ex)
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
                articulo.CodColor = articuloActualizar.CodColor;
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
                _context.SubmitChanges();
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

        public bool GuardarColor(Articulos_Color nuevoColor)
        {
            try
            {
                nuevoColor.BajaLogica = false;
                _context.Articulos_Colors.InsertOnSubmit(nuevoColor);
                _context.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //TODO: Fijarse de cambiar esta logica, en el STOCK controller hay para guardar un egreso. Y en este controller
        //TODO: tambien hay un ActualizarStock().
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

        public DataSet ListarColores()
        {
            var colores = new DataSet();
            colores.Tables.Add();
            colores.Tables[0].Columns.Add("Codigo", typeof (string));
            colores.Tables[0].Columns.Add("Descripcion", typeof (string));
                
            var coloresBd = _context.Articulos_Colors.Where(color => !(color.BajaLogica.HasValue && color.BajaLogica.Value)).OrderBy(color => color.Codigo).ToList();

            foreach (var color in coloresBd)
                colores.Tables[0].Rows.Add(color.Codigo,String.Format("{0} - {1}",color.Codigo,color.Descripcion));

            return colores;
        }

        public List<Articulos_Color> ListarColoresObjeto()
        {
            return (_context.Articulos_Colors.Where(color => !(color.BajaLogica.HasValue && color.BajaLogica.Value) && (color.Codigo != "0")).OrderBy(color => color.Codigo)).ToList();
        }

        public bool EliminarArticulosColor(int idColor)
        {
            try
            {
                var color = _context.Articulos_Colors.Where(col => col.idColor == idColor).Single();
                color.BajaLogica = true;
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
