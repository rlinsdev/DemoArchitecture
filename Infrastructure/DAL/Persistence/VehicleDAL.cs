using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using System.Data.SqlClient;

namespace DAL.Persistence
{
	public class VehicleDAL: Conection
	{
		#region Save
		/// <summary>
		/// Save Vehicles
		/// </summary>
		public void Save(VehicleModel v)
		{
			try
			{
				OpenConn();
				cmd = new SqlCommand("INSERT INTO Vehicle (IdVehicle, Name, Color) Values(@v1, @v2, @v3)");
				cmd.Parameters.AddWithValue("@v1", new Guid());
				cmd.Parameters.AddWithValue("@v2", v.Name);
				cmd.Parameters.AddWithValue("@v3", v.Color);

				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			finally
			{
				CloseConn();
			}
		}

		#endregion

		#region GetAllVehicles
		/// <summary>
		///  Get All vehicles
		/// </summary>
		public List<VehicleModel> GetAllVehicles()
		{
			try
			{
				OpenConn();
				cmd = new SqlCommand("SELECT * FROM Vehicle");

				VehicleModel v = null;
				List<VehicleModel> _vehicles = new List<VehicleModel>();

				while(dr.Read())
				{
					v = new VehicleModel();
					v.Color = dr["Color"].ToString();
					v.Name = dr["Name"].ToString();
					v.IdVehicle = new Guid(dr["IdVehicle"].ToString());

					// Add object to list
					_vehicles.Add(v);
				}
				// Return list
				return _vehicles;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			finally
			{
				CloseConn();
			}
		}

		#endregion
	}
}
