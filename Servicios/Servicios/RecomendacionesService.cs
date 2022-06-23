using Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Turistiando.Model;

namespace Servicios.Servicios
{
    internal class RecomendacionesService : IRecomendaciones
    {
        public List<RecomendacionModel> GetLugaresVisitados(IDbConnection dbConnection)
        {
            throw new NotImplementedException();
        }

        public List<RecomendacionModel> GetLugaresVisitados()
        {
            throw new NotImplementedException();
        }

        public RecomendacionModel GetLugareVisitado()
        {
            throw new NotImplementedException();
        }
    }
}
