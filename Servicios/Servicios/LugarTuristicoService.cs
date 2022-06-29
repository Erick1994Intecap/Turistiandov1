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
        public List<LugarTursiticoModel> EditLugar(IDbConnection dbConnection, int idLugar)
        {
            var lugarActual = dbConnection.Query<LugarTursiticoModel>("SELECT * FROM LUGAR_TURISTICO WHERE Id_lugar = " + idLugar);
            

            foreach (var item in lugarActual)
            {
                item.Visitas++;
                
                dbConnection.Query<LugarTursiticoModel>("UPDATE LUGAR_TURISTICO SET Visitas =" + item.Visitas + " WHERE Id_lugar = " + idLugar);
            }

            return (List<LugarTursiticoModel>)dbConnection.Query<LugarTursiticoModel>("SELECT * FROM LUGAR_TURISTICO WHERE Id_lugar = " + idLugar);
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
