using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Organicart.Models;

namespace Organicart.Controllers
{
    /*
    Integrantes: 
    - Fernando Josué Montano González. MG210111 | 
    - Andrea Guadalupe Velásquez Joyar. VJ210576 |
    - Ivania María Lebrón Flores. LF212591 | 
    - Luciana María Munguía Villacorta. MV210941 |
    - Carlos Vicente Castillo Sayes. CS210003 |
    */
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

                InsertProducts();
            }
            catch (Exception errorFound)
            {
                MessageBox.Show($"There was an error: {errorFound.Message}");
            }
        }

        #region AddProducts
        string desiredPath = Environment.CurrentDirectory.Replace("\\Organicart\\bin\\Debug",
            "\\DatabaseQuery");
        private void InsertProducts()
        {
            using (var db = new OrganicartEntities())
            {
                // obtenemos la imagen de la ruta especificada, en este caso, agua.
                var image = Image.FromFile($"{desiredPath}\\agua.jpg");
                var agua = new product // hacemos un elemento de tipo product y llenamos sus atributos.
                {
                    name = "Agua",
                    photo = ImageToInsert(image),
                    category_id = 2,
                    stock = 10,
                    price = 1.25,
                };

                image = Image.FromFile($"{desiredPath}\\arroz.jpg");
                var arroz = new product
                {
                    name = "Libra de Arroz",
                    photo = ImageToInsert(image),
                    category_id = 4,
                    stock = 12,
                    price = 2.50
                };

                image = Image.FromFile($"{desiredPath}\\banana.jpg");
                var banana = new product
                {
                    name = "Racimo de bananas",
                    photo = ImageToInsert(image),
                    category_id = 1,
                    stock = 40,
                    price = 1.50,
                };

                image = Image.FromFile($"{desiredPath}\\brocoli.jpg");
                var brocoli = new product
                {
                    name = "Brocoli",
                    photo = ImageToInsert(image),
                    category_id = 3,
                    stock = 300,
                    price = 0.50,
                };

                image = Image.FromFile($"{desiredPath}\\cheez.jpg");
                var cheez = new product
                {
                    name = "Caja Cheez It",
                    photo = ImageToInsert(image),
                    category_id = 6,
                    stock = 20,
                    price = 2.75,
                };

                image = Image.FromFile($"{desiredPath}\\coca-cola.jpg");
                var coca = new product
                {
                    name = "Coca Cola Lata",
                    photo = ImageToInsert(image),
                    category_id = 2,
                    stock = 50,
                    price = 1.00,
                };

                image = Image.FromFile($"{desiredPath}\\hershey.jpg");
                var chocolate = new product
                {
                    name = "Chocolate blanco Hershey Grande",
                    photo = ImageToInsert(image),
                    category_id = 6,
                    stock = 30,
                    price = 4.50,
                };

                image = Image.FromFile($"{desiredPath}\\kellogs.jpg");
                var kellogs = new product
                {
                    name = "Kellogs - Corn Flakes",
                    photo = ImageToInsert(image),
                    category_id = 4,
                    stock = 5,
                    price = 4.00,
                };

                image = Image.FromFile($"{desiredPath}\\leche.jpg");
                var leche = new product
                {
                    name = "1L de Leche",
                    photo = ImageToInsert(image),
                    category_id = 5,
                    stock = 100,
                    price = 2.75,
                };

                image = Image.FromFile($"{desiredPath}\\manzana.jpg");
                var manzana = new product
                {
                    name = "Manzanas Rojas",
                    photo = ImageToInsert(image),
                    category_id = 1,
                    stock = 400,
                    price = 1.25,
                };

                image = Image.FromFile($"{desiredPath}\\naranja.jpg");
                var naranja = new product
                {
                    name = "Naranja jugosa",
                    photo = ImageToInsert(image),
                    category_id = 1,
                    stock = 250,
                    price = 1.00,
                };

                image = Image.FromFile($"{desiredPath}\\oreo.jpg");
                var oreo = new product
                {
                    name = "Galletas Oreo 6 galletas",
                    photo = ImageToInsert(image),
                    category_id = 6,
                    stock = 10,
                    price = 2.50,
                };

                image = Image.FromFile($"{desiredPath}\\queso.jpg");
                var queso = new product
                {
                    name = "Queso fresco",
                    photo = ImageToInsert(image),
                    category_id = 5,
                    stock = 40,
                    price = 2.50,
                };

                image = Image.FromFile($"{desiredPath}\\te.jpg");
                var te = new product
                {
                    name = "Té Lipton Frambuesa",
                    photo = ImageToInsert(image),
                    category_id = 2,
                    stock = 400,
                    price = 1.00,
                };

                image = Image.FromFile($"{desiredPath}\\zanahoria.jpg");
                var zanahoria = new product
                {
                    name = "Libra de zanahorias",
                    photo = ImageToInsert(image),
                    category_id = 3,
                    stock = 12,
                    price = 2.50,
                };

                image = Image.FromFile($"{desiredPath}\\zucaritas.jpg");
                var zucaritas = new product
                {
                    name = "Zucaritas",
                    photo = ImageToInsert(image),
                    category_id = 4,
                    stock = 10,
                    price = 2.25,
                };
                try
                {
                    db.products.Add(agua); // guardar los items con Entity Framework
                    db.products.Add(arroz); // guardar los items con Entity Framework
                    db.products.Add(banana); // guardar los items con Entity Framework
                    db.products.Add(brocoli); // guardar los items con Entity Framework
                    db.products.Add(cheez); // guardar los items con Entity Framework
                    db.products.Add(coca); // guardar los items con Entity Framework
                    db.products.Add(chocolate); // guardar los items con Entity Framework
                    db.products.Add(kellogs); // guardar los items con Entity Framework
                    db.products.Add(leche); // guardar los items con Entity Framework
                    db.products.Add(manzana); // guardar los items con Entity Framework
                    db.products.Add(naranja); // guardar los items con Entity Framework
                    db.products.Add(oreo); // guardar los items con Entity Framework
                    db.products.Add(queso); // guardar los items con Entity Framework
                    db.products.Add(te); // guardar los items con Entity Framework
                    db.products.Add(zanahoria); // guardar los items con Entity Framework
                    db.products.Add(zucaritas); // guardar los items con Entity Framework

                    db.SaveChanges(); // aplicar los cambios en la base de datos
                }
                catch
                {
                }
            }
        }

        /* este metodo transforma la imagen a un array de bytes que nos permite
            almacenarlo en SQL. */
        public byte[] ImageToInsert(Image image)
        {
            using (var memory = new MemoryStream())
            {
                image.Save(memory, System.Drawing.Imaging.ImageFormat.Jpeg);

                return memory.ToArray();
            }
        }
        #endregion
    }
}
