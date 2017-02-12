using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using MySql.Data.MySqlClient;
using BusinessEntities;
using System.Data;
using System.Configuration;
using MySql.Data;

//the stage-Avenged 



namespace WebVeterinaria
{
    /// <summary>
    /// Descripción breve de VeterinariaService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class VeterinariaService : System.Web.Services.WebService
    {
        
        

        
        [WebMethod]
        public void InsertMascota(String Nombre, string Raza, string Especie, float Peso, String Genero, int Edad)
        {

            string connStr = "server=localhost;user id=root;database=veterinariayei";
            using (MySqlConnection con = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand("InsertMascota", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Nombre", MySqlDbType.VarChar, 50).Value = Nombre;
                    cmd.Parameters.Add("@Raza", MySqlDbType.VarChar, 50).Value = Raza;
                    cmd.Parameters.Add("@Especie", MySqlDbType.VarChar, 65532).Value = Especie;
                    cmd.Parameters.Add("@Peso", MySqlDbType.Float).Value = Peso;
                    cmd.Parameters.Add("@Genero", MySqlDbType.VarChar, 65532).Value = Genero;
                    cmd.Parameters.Add("@Edad", MySqlDbType.Int16).Value = Edad;
                    cmd.ExecuteNonQuery();

                }
            }
        }
        [WebMethod]
        public DataTable MostrarMascotas()
        {
            string connStr = "server=localhost;user id=root;database=veterinariayei";
            using (MySqlConnection con = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM mascotas"))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "Mascotas";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

    }
}
