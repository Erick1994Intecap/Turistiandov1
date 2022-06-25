using Dapper;
using Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Turistiando.Model;

namespace Servicios.Servicios
{

    public class RecoCategoriaService : IRecomendacionCategoria
    {
        private readonly IDbConnection _dbConnection;
        public RecoCategoriaService(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<RecoCategoriaModel> GetLugarCategoria()
        {
            throw new NotImplementedException();
        }

        public RecoCategoriaModel GetLugaresCategoria()
        {
            throw new NotImplementedException();
        }

        public List<RecoCategoriaModel> GetLugaresCategoria(IDbConnection dbConnection, string categoria, string latitud, string longitud)
        {
            dbConnection.Query<RecomendacionModel>("EXEC SP_GENERA_CERCANOS_CATEGORIA " + latitud + ", " + longitud +", '"+ categoria+"'");
            return (List<RecoCategoriaModel>)dbConnection.Query<RecoCategoriaModel>("SELECT * FROM [RECOMENDACIONES_CERCANAS]");
        }
    }
}
