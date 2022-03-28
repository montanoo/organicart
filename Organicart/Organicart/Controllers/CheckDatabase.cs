using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace Organicart.Controllers
{
    class CheckDatabase
    {
        string sqlConnection = "Persist Security Info=False; Integrated Security=true; Initial Catalog=Organicart; server=(local); TrustServerCertificate=True";

        public void Check()
        {
            bool alreadyExists;
            string fromMaster = sqlConnection.Replace("Initial Catalog=Organicart", "Initial Catalog=master");

            var cmdText = "SELECT COUNT(*) FROM master.dbo.sysdatabases where name=@database";

            using (var sqlConn = new SqlConnection(fromMaster))
            {
                using (var sqlCmd = new SqlCommand(cmdText, sqlConn))
                {
                    sqlCmd.Parameters.Add("@database", SqlDbType.NVarChar).Value = "Organicart";

                    sqlConn.Open();
                    alreadyExists = Convert.ToInt32(sqlCmd.ExecuteScalar()) == 1;
                }
            }

            if (!alreadyExists)
            {
                CreateDatabase();
            }
        }

        private void CreateDatabase()
        {
            try
            {
                string fromMaster = sqlConnection.Replace("Initial Catalog=Organicart", "Initial Catalog=master");
                SqlConnection connectionString = new SqlConnection(fromMaster);

                connectionString.Open();

                string desiredPath = Environment.CurrentDirectory.Replace("\\Organicart\\bin\\Debug",
                    "\\DatabaseQuery");
                string data = File.ReadAllText(desiredPath + @"\organicart.sql");
                Server server = new Server(new ServerConnection(connectionString));
                server.ConnectionContext.ExecuteNonQuery(data);
            }
            catch (Exception errorFound)
            {
                MessageBox.Show($"There was an error: {errorFound.Message}");
            }
        }
    }
}
