using FleetManager.DapperDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.DapperDAL.Repositories.Interfaces;
public interface IFuelCardRepository {
    Task<List<FuelCardModel>> GetFuelCardsByDriverIDAsync(int driverID);
}
