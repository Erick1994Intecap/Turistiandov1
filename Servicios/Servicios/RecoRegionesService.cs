using Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Turistiando.Model;

namespace Servicios.Servicios
{
    internal class RecoRegionesService : IRecoRegiones
    {
        public List<RecoRegionModel> GetLugaresVisitados(IDbConnection dbConnection)
        {
            throw new NotImplementedException();
        }

        public List<RecoRegionModel> GetLugaresVisitados()
        {
            throw new NotImplementedException();
        }

        public RecoRegionModel GetLugareVisitado()
        {
            throw new NotImplementedException();
        }
    }
}
