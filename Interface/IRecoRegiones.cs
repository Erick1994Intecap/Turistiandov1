using System;
using System.Collections.Generic;
using System.Text;
using Turistiando.Model;

namespace Interface
{
    public interface IRecoRegiones
    {
        RecoRegionModel GetRecomendacionRegion();
        List<RecoRegionModel> GetRecomendacionesRegiones(System.Data.IDbConnection dbConnection, string categoria);
        List<RecoRegionModel> GetRecomendacionesRegiones();
    }
}
