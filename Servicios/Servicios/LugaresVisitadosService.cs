using Dapper;
using Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Turistiando.Model;

namespace Servicios.Servicios
{
    public class LugaresVisitadosService : ILugaresVisitados
    {
        private readonly IDbConnection _dbConnection;

        public LugaresVisitadosService(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<LugaresVisitadosModel> GetLugaresVisitados(IDbConnection dbConnection)
        => (List<LugaresVisitadosModel>)dbConnection.Query<LugaresVisitadosModel>("SELECT * FROM [RECOMENDACIONES_CERCANAS]");

        public List<LugaresVisitadosModel> GetLugaresVisitados()
        {
            throw new NotImplementedException();
        }

        public LugaresVisitadosModel GetLugareVisitado()
        {
            throw new NotImplementedException();
        }
    }
}
