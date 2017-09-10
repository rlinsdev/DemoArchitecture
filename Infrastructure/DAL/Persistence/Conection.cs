using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Persistence
{
	public class Conection
	{
		protected SqlConnection con;
		protected SqlCommand cmd;
		protected SqlDataReader dr;

		#region Open Conn
		/// <summary>
		/// Open connection with DataBase
		/// </summary>
		protected void OpenConn()
		{
			try
			{				
				con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["dbCeltrinoDemo"].ConnectionString);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		#endregion

		#region CloseConn
		/// <summary>
		/// Close connection with data Base
		/// </summary>
		protected void CloseConn()
		{
			try
			{
				con.Close();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		#endregion
	}
}
