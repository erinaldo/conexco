using System;
using System.Configuration.Install;
using System.IO;
using System.Reflection;
using System.Data.SqlClient;
using System.ServiceProcess;
using Conexco.BDActualizar.Properties;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using Settings = Conexco.BDActualizar.Properties.Settings;

namespace Conexco.BDActualizar
{
    partial class ConexcoDBActualizador : Installer
    {
        public ConexcoDBActualizador()
        {
            InitializeComponent();
        }

        public override void Install(System.Collections.IDictionary stateSaver)
        {
            base.Install(stateSaver);

            try
            {
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
