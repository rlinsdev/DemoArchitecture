using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace Demo.Business
{
    public class VehicleBusiness : Interfaces.IVehicalBusiness
    {
		public string GetAllVehicles()
		{
			DAL.Persistence.VehicleDAL _vehicleDAL = new DAL.Persistence.VehicleDAL();
			return Serialize.SerializeObject(_vehicleDAL.GetAllVehicles());
		}
    }
}
