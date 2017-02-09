using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.ComponentModel;

namespace DataAccessLayer
#region Conexion
//ConexionString
[SettingsBindableAttribute(true)]
public override string ConnectionString { get; set; }

//"Persist Security Info=False;Integrated Security=true;Initial Catalog=Northwind;server=(local)"
//"Persist Security Info=False;User ID=*****;Password=*****;Initial Catalog=AdventureWorks;Server=MySqlServer"


	//Uso de cadena de conexiones 
private static void OpenSqlConnection() 
{
	string connectionString = Get.ConnectionString();

	using (SqlConnection connection = new SqlConnection())
	{
		connection.ConnectionString = connectionString;

		connection.Open();

		Console.WriteLine("State: {0}", connection.State);
		Console.WriteLine("ConnectionString: {0}",
			connection.ConnectionString);
	}
}


static private string GetConnectionString()
{
	// To avoid storing the connection string in your code, 
	// you can retrieve it from a configuration file.
	return "Data Source=MSSQL1;Initial Catalog=AdventureWorks;"
		+ "Integrated Security=true;";
}
#endregion Conexion


//Query
public class DAL
#region

#region Select


#endregion Select

#endregion


