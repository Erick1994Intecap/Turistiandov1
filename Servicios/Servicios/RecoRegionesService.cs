using Dapper;
using Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Turistiando.Model;

namespace Servicios.Servicios
{
    public class RecoRegionesService : IRecoRegiones
    {
        private readonly IDbConnection _dbConnection;

        public RecoRegionesService(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<RecoRegionModel> GetRecomendacionesRegiones(IDbConnection dbConnection, string categoria)
        {
            return (List<RecoRegionModel>)dbConnection.Query<RecoRegionModel>("SELECT * FROM [dbo].[FN_REGIONES_CATEGORIA] ('"+categoria+"')");
        }

        public List<RecoRegionModel> GetRecomendacionesRegiones()
        {
            throw new NotImplementedException();
        }

        public RecoRegionModel GetRecomendacionRegion()
        {
            throw new NotImplementedException();
        }
    }
}
