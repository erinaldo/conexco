using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Conexco.Model;

namespace Conexco.Controller
{
    public class ClientesController
    {
        private ConexcoDataClassesDataContext _context;

        public void AgregarCliente(Cliente cliente)
        {
            _context = new ConexcoDataClassesDataContext();
            cliente.CondicionIVA = _context.CondicionIVAs.Single(iva => iva.idCondicionIVA == cliente.idCondicionIVA);
            _context.Clientes.InsertOnSubmit(cliente);
            try
            {
                _context.SubmitChanges();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<Cliente> ListarClientes()
        {
            _context = new ConexcoDataClassesDataContext();
            var a = (from cliente in _context.Clientes select cliente).ToList();
            return a;
        }
    }
}
