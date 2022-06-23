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
        public List<RecoCategoriaModel> GetLugaresVisitados(IDbConnection dbConnection)
        {
            throw new NotImplementedException();
        }

        public List<RecoCategoriaModel> GetLugaresVisitados()
        {
            throw new NotImplementedException();
        }

        public RecoCategoriaModel GetLugareVisitado()
        {
            throw new NotImplementedException();
        }
    }
}
