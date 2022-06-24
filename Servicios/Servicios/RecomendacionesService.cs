using Dapper;
using Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Turistiando.Model;

namespace Servicios.Servicios
{
    public class RecomendacionesService : IRecomendaciones
    {
        private readonly IDbConnection _dbConnection;

        public RecomendacionesService(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<RecomendacionModel> GetLugareRecomendados()
        {
            throw new NotImplementedException();
        }

        public List<RecomendacionModel> GetLugaresRecomendados(IDbConnection dbConnection, string latitud, string longitud)
        {
            dbConnection.Query<RecomendacionModel>("EXEC SP_GENERA_CERCANOS "+ latitud + ", "+ longitud);
            return (List<RecomendacionModel>)dbConnection.Query<RecomendacionModel>("SELECT * FROM [RECOMENDACIONES_CERCANAS]");
        }

        public RecomendacionModel GetLugarRecomendado()
        {
            throw new NotImplementedException();
        }
    }
}
