using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace DataAccessLayer

public static class DAL
{
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

	#region Conexion-Variable

	public static string passw = "";
	public static string connectionString;
	public static MySqlConnection connection = new SqlConnection();
	public static MySqlCommand command;
	public static MySqlDataReader Reader;
	#endregion Conexion-Variables

	//Query

	#region Query
	public string Usuario;
	public string password;
	public string Nombre;
	public string ApellidoMaterno;
	public string ApellidoPaterno;


	public string Consulta(int pId, string Nci)

	{

		string conexion = "Server=localhost;Database=alcaldia;User ID=root;Password=41370123;Pooling=false;";

		MySqlConnection conn = new MySqlConnection(conexion);

		conn.Open();

		string query = "Select * From contribuyentes Where Cedula = '" + pId.ToString() + "' and Nacio = '" + Nci.ToString() + "'";


		MySqlCommand mycomand = new MySqlCommand(query, conn);

		MySqlDataReader myreader = mycomand.ExecuteReader();



		myreader.Read();

		Usuario = myreader["usuario"].ToString();

		password = myreader["contraseña"].ToString();


		return Usuario;

		return password;


		if (myreader.HasRows)


		{

			while (myreader.Read())

				Usuario = myreader["Usuario"].ToString();

			password = myreader["password"].ToString();


			return Usuario;

			return password;

		}


		else

		{

			Console.WriteLine("not found");

		}
	}
		
	#region Select

		#region Usuario  
		//primera parte de usuario
	public static bool VerifyUser(string Usuario, string password)
	{
		var User = Usuario;
		var passw = password;

		if ((User == passw) && (User == passw))
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}

//segunda parte 


#endregion Usuario

#region Mascotas

//Segunda parte de mascotas
#endregion Mascotas


//Crea para select
#endregion

#region Insertar

public static void  INSERTINTOUsuario(string ApellidoParterno, string ApellidoMaterno, string Contraseña)
{

	string query = "INSERT INTO usuario (usuario, 'name', lastname, password, ApellidoMaterno, ApellidoPaterno) values ('" + Usuario + "','" + ApellidoMaterno + "','" + ApellidoParterno + "','" + Contraseña + "');";
	DbDataReader = new MySqlCommand(query, MySqlConnection);
	MySqlCommand.ExecuteQuery();
}

public static bool verifyuserToIns(string Usuario)
{
	string query = "SELECT * FROM Usuari WHERE	Id='" + Usuario + "';";
	MySqlCommand = new MySqlCommand(query, MySqlConnection);
	MySqlDataReader = DbCommand.ExcecuteReader();
	while (MySqlDataReader.Read())
	{
		//userlist?
	}	

}

#endregion Insertar

#endregion Query
}

