using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Conexco.Model;

namespace Conexco.Controller
{
    public class LocalidadesController
    {
        private ConexcoDataClassesDataContext _context;

        public LocalidadesController()
        {
            _context = new ConexcoDataClassesDataContext();
        }

        public void CrearProvincias()
        {
            var bsas = new Provincia() {Provincia1 = "Buenos Aires"};
            var cordoba = new Provincia() {Provincia1 = "Cordoba"};
            _context.Provincias.InsertOnSubmit(bsas);
            _context.Provincias.InsertOnSubmit(cordoba);            
            _context.SubmitChanges();
        }

        public List<Provincia> ListarProvincias()
        {
            return (_context.Provincias.Select(provincia => provincia)).ToList();
        }

        public List<Localidade> ListarLocalidadesPorProvincia(Provincia provincia)
        {
            return (_context.Localidades.Where(loc => loc.idProvincia == provincia.idProvincia)).ToList();
        }

        public bool GuardarNuevaLocalidad(Localidade localidad)
        {
            _context.Localidades.InsertOnSubmit(localidad);

            try
            {
                _context.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Provincia DatosProvincia(string nombreProvincia)
        {
            try
            {
                return _context.Provincias.Single(prov => prov.Provincia1 == nombreProvincia);
            }
            catch (Exception)
            {
                return new Provincia();
            }
        }
    }
}
