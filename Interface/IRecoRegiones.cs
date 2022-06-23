using System;
using System.Collections.Generic;
using System.Text;
using Turistiando.Model;

namespace Interface
{
    public interface IRecoRegiones
    {
        RecoRegionModel GetLugareVisitado();
        List<RecoRegionModel> GetLugaresVisitados(System.Data.IDbConnection dbConnection);
        List<RecoRegionModel> GetLugaresVisitados();
    }
}
