using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Data.SqlClient;
using Conexco.BDActualizador.Properties;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using Conexco.BDActualizador.Properties;
using Settings=Conexco.BDActualizador.Properties.Settings;


namespace Conexco.BDActualizador
{
    [RunInstaller(true)]
    public partial class BDActualizar : Installer
    {
        public BDActualizar()
        {
            InitializeComponent();
        }

        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);

            try
            {
                var script = LeerSqlScript("StoreProcedures.txt");
                EjecutarSql("Conexco", script);
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
