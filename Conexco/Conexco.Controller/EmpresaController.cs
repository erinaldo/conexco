using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Conexco.Model;

namespace Conexco.Controller
{
    public class EmpresaController
    {
        private Conexco.Model.ConexcoDataClassesDataContext _context;

        public EmpresaController()
        {
            _context = new ConexcoDataClassesDataContext();
        }

        public bool CrearOActualizarEmpresa(Empresa empresa)
        {
            var empresaGuardada = DatosEmpresa();
            if (empresaGuardada != null)
            {
                empresaGuardada.RazonSocial = empresa.RazonSocial;
                empresaGuardada.Nombre = empresa.Nombre;
                empresaGuardada.Apellido = empresa.Apellido;
                empresaGuardada.Telefono = empresa.Telefono;
                empresaGuardada.Fax = empresa.Fax;
                empresaGuardada.Email = empresa.Email;
                empresaGuardada.Web = empresa.Web;
                empresaGuardada.Domicilio = empresa.Domicilio;
                empresaGuardada.Provincia = empresa.Provincia;
                empresaGuardada.Localidad = empresa.Localidad;
                empresaGuardada.CodPostal = empresa.CodPostal;
                empresaGuardada.CUIT = empresa.CUIT;
                empresaGuardada.idCondicionIVA = empresa.idCondicionIVA;
                empresaGuardada.InicioActividades = empresa.InicioActividades;
                empresaGuardada.IngBrutos = empresa.IngBrutos;
                empresaGuardada.PorcentajeIVA = empresa.PorcentajeIVA;
            }
            else
            {
                _context.Empresas.InsertOnSubmit(empresa);
            }

            try
            {
                _context.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Empresa DatosEmpresa()
        {
            return _context.Empresas.Select(emp => emp).FirstOrDefault();
        }
    }
}
