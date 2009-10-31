﻿using System;
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

        public ClientesController()
        {
            _context = new ConexcoDataClassesDataContext();
        }

        public bool AgregarCliente(Cliente cliente)
        {
            try
            {
                cliente.CondicionIVA = _context.CondicionIVAs.Single(iva => iva.idCondicionIVA == cliente.idCondicionIVA);
                _context.Clientes.InsertOnSubmit(cliente);
                _context.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ModificarCliente(Cliente cliente)
        {
            try
            {
                cliente.CondicionIVA = _context.CondicionIVAs.Single(iva => iva.idCondicionIVA == cliente.idCondicionIVA);
                var clienteGuardado = DatosCliente(cliente.idCliente);

                clienteGuardado.Codigo = cliente.Codigo;
                clienteGuardado.RazonSocial = cliente.RazonSocial;
                clienteGuardado.Nombre = cliente.Nombre;
                clienteGuardado.Apellido = cliente.Apellido;
                clienteGuardado.CUIT = cliente.CUIT;
                clienteGuardado.idCondicionIVA = cliente.idCondicionIVA;
                clienteGuardado.CondicionIVA = cliente.CondicionIVA;
                clienteGuardado.Email = cliente.Email;
                clienteGuardado.Pagos = cliente.Pagos;
                clienteGuardado.Web = cliente.Web;

                var domicilio = cliente.Clientes_Domicilios.First();
                clienteGuardado.Clientes_Domicilios.First().Domicilio = domicilio.Domicilio;
                clienteGuardado.Clientes_Domicilios.First().Provincia = domicilio.Provincia;
                clienteGuardado.Clientes_Domicilios.First().Localidad = domicilio.Localidad;
                clienteGuardado.Clientes_Domicilios.First().CodPostal = domicilio.CodPostal;

                var telefono = clienteGuardado.Clientes_Telefonos.First();
                clienteGuardado.Clientes_Telefonos.First().Telefono = telefono.Telefono;
                clienteGuardado.Clientes_Telefonos.First().Fax = telefono.Fax;

                _context.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool GuardarCambios()
        {
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

        public bool AgregarDomicilio(Clientes_Domicilio domicilio)
        {
            try
            {
                _context.Clientes_Domicilios.InsertOnSubmit(domicilio);
                _context.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Cliente> ListarClientes()
        {
            return (_context.Clientes.Select(cliente => cliente)).ToList();
        }

        public List<Clientes_Domicilio> ListarDomicilios(int idCliente)
        {
            return (_context.Clientes_Domicilios.Where(dom => dom.idCliente == idCliente)).ToList();
        }

        public List<Clientes_Telefono> ListarTelefonos(int idCliente)
        {
            return (_context.Clientes_Telefonos.Where(tel => tel.idCliente == idCliente)).ToList();
        }

        public List<Clientes_Contacto> ListarContactos(int idCliente)
        {
            return (_context.Clientes_Contactos.Where(con => con.idCliente == idCliente)).ToList();
        }

        public List<Clientes_Transportista> ListarTransportistas(int idCliente)
        {
            return (_context.Clientes_Transportistas.Where(trans => trans.idCliente == idCliente)).ToList();
        }

        public Cliente DatosCliente(int idCliente)
        {
            return _context.Clientes.Single(cte => cte.idCliente == idCliente);
        }

        public Clientes_Domicilio DatosDomicilio(int idDomicilio)
        {
            return _context.Clientes_Domicilios.Single(dom => dom.idDomicilio == idDomicilio);
        }

        public Clientes_Telefono DatosTelefono(int idTelefono)
        {
            return _context.Clientes_Telefonos.Single(tel => tel.idTelefono == idTelefono);
        }

        public Clientes_Contacto DatosContacto(int idContacto)
        {
            return _context.Clientes_Contactos.Single(con => con.idContacto == idContacto);
        }

        public Clientes_Transportista DatosTransportista(int idTransportista)
        {
            return _context.Clientes_Transportistas.Single(trans => trans.idTransportista == idTransportista);
        }

        public bool EliminarCliente(int idCliente)
        {
            try
            {
                var cliente = DatosCliente(idCliente);
                _context.Clientes.DeleteOnSubmit(cliente);
                foreach (var contacto in _context.Clientes_Contactos)
                {
                    if(contacto.idCliente == idCliente)
                        _context.Clientes_Contactos.DeleteOnSubmit(contacto);
                }
                foreach (var domicilio in _context.Clientes_Domicilios)
                {
                    if(domicilio.idCliente == idCliente)
                        _context.Clientes_Domicilios.DeleteOnSubmit(domicilio);
                }
                foreach(var telefono in _context.Clientes_Telefonos)
                {
                    if(telefono.idCliente == idCliente)
                        _context.Clientes_Telefonos.DeleteOnSubmit(telefono);
                }
                foreach (var transportista in _context.Clientes_Transportistas)
                {
                    if(transportista.idCliente == idCliente)
                        _context.Clientes_Transportistas.DeleteOnSubmit(transportista);
                }
                _context.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EliminarDomicilio(int idDomicilio)
        {
            try
            {
                var domicilio = _context.Clientes_Domicilios.Single(dom => dom.idDomicilio == idDomicilio);
                _context.Clientes_Domicilios.DeleteOnSubmit(domicilio);
                _context.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EliminarTelefono(int idTelefono)
        {
            try
            {
                var telefono = _context.Clientes_Telefonos.Single(tel => tel.idTelefono == idTelefono);
                _context.Clientes_Telefonos.DeleteOnSubmit(telefono);
                _context.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EliminarContacto(int idContacto)
        {
            try
            {
                var contacto = _context.Clientes_Contactos.Single(con => con.idContacto == idContacto);
                _context.Clientes_Contactos.DeleteOnSubmit(contacto);
                _context.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EliminarTransportista(int isTransportista)
        {
            try
            {
                var transportista = _context.Clientes_Transportistas.Single(trans => trans.idTransportista == isTransportista);
                _context.Clientes_Transportistas.DeleteOnSubmit(transportista);
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
