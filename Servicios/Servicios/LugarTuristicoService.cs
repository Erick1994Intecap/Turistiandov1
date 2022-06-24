using Dapper;
using Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Turistiando.Model;

namespace Servicios.Servicios
{
    public class LugarTuristicoService : ILugarTuristico
    {
        private readonly IDbConnection _dbConnection;
        public LugarTuristicoService(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public void EditLugar(LugarTursiticoModel lugar)
        {
            throw new NotImplementedException();
        }

        public List<LugarTursiticoModel> GetLugaresTuristicos(IDbConnection dbConnection)
        {
            return (List<LugarTursiticoModel>)dbConnection.Query<LugarTursiticoModel>("SELECT * FROM [vw_lugares_turisticos]");
        }

        public List<LugarTursiticoModel> GetLugaresTuristicos()
        {
            throw new NotImplementedException();
        }

        public LugarTursiticoModel GetLugaresTuristico()
        {
            throw new NotImplementedException();
        }
    }
}
