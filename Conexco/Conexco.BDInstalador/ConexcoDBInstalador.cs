using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Data.SqlClient;
using Conexco.BDInstalador.Properties;


namespace Conexco.BDInstalador
{
    [RunInstaller(true)]
    public partial class ConexcoDBInstalador : Installer
    {
        public ConexcoDBInstalador()
        {
            InitializeComponent();
        }

        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);
            string sqlCrearBaseDatos = "CREATE DATABASE Conexco";
            try
            {
                EjecutarSql("master", sqlCrearBaseDatos);
                EjecutarSql("Conexco", "SCRIPT PARA CREAR LAS TABLAS, INSERT Y STORED PROCEDURES");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void EjecutarSql(string nombreBaseDatos, string sqlQuery)
        {
            var conn = new SqlConnection(Settings.Default.MasterConnectionString);
            try
            {
                conn.Open();
                var command = new SqlCommand(sqlQuery, conn);
                command.Connection.ChangeDatabase(nombreBaseDatos);

                command.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public string LeerSqlScript()
        {
            try
            {

            }
            catch (Exception)
            {
                
                throw;
            }

            return "";
        }
    }
}
