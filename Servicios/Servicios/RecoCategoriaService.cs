﻿using Dapper;
using Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Turistiando.Model;

namespace Servicios.Servicios
{

    public class RecoCategoriaService : IRecoCategoria
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

        public List<RecoCategoriaModel> GetLugaresCategoria(IDbConnection dbConnection)
        {
            return (List<RecoCategoriaModel>)dbConnection.Query<RecoCategoriaModel>("SELECT * FROM [RECOMENDACIONES_CERCANAS]");
        }
    }
}