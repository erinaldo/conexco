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
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using Settings=Conexco.BDInstalador.Properties.Settings;


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

            try
            {
                EjecutarSql("master", LeerSqlScript("Create.txt"));
                EjecutarSql("Conexco", LeerSqlScript("ScriptTablas.txt"));
                EjecutarSql("Conexco", LeerSqlScript("Inserts.txt"));
                EjecutarSql("Conexco", LeerSqlScript("StoreProcedures.txt"));
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

                var serverConnection = new ServerConnection(conn);
                var server = new Server(serverConnection);
                server.ConnectionContext.ExecuteNonQuery(sqlQuery);
            }
            finally
            {
                conn.Close();
            }
        }

        public string LeerSqlScript(string nombreArchivo)
        {
            try
            {
                var assembly = Assembly.GetExecutingAssembly();

                var stream = assembly.GetManifestResourceStream(assembly.GetType(this.ToString()).Namespace + "." + nombreArchivo);

                var reader = new StreamReader(stream);

                return reader.ReadToEnd();
            }
            catch (Exception)
            {
                return "";
            }

        }
    }
}
