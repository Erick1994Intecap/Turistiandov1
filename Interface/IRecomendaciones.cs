using System;
using System.Collections.Generic;
using System.Text;
using Turistiando.Model;

namespace Interface
{
    public interface IRecomendaciones
    {
        RecomendacionModel GetLugareVisitado();
        List<RecomendacionModel> GetLugaresVisitados(System.Data.IDbConnection dbConnection);
        List<RecomendacionModel> GetLugaresVisitados();
    }
}
