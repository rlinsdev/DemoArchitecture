using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using Dapper;

namespace DAL.Persistence
{
	public class VehicleDapperDAL : Conection
	{
		#region GetAllVehiclesDapper
		/// <summary>
		/// Method responsable to get all vehicles.
		/// This call was made with Dapper Framework
		/// </summary>
		/// <returns></returns>
		public List<VehicleModel> GetAllVehiclesDapper()
		{
			try
			{
				var result = con.Query("SELECT * FROM tbVehicle");

				VehicleModel v = null;
				List<VehicleModel> _vehicles = new List<VehicleModel>();

				foreach (dynamic vehicle in result)
				{
					v = new VehicleModel();

					v.Color = vehicle.Color;
					v.IdVehicle = vehicle.IdVehicle;
					v.Name = vehicle.Name;

					_vehicles.Add(v);
				}
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
