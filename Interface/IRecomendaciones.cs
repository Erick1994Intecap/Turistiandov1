using System;
using System.Collections.Generic;
using System.Text;
using Turistiando.Model;

namespace Interface
{
    public interface IRecomendaciones
    {
        RecomendacionModel GetLugarRecomendado();
        List<RecomendacionModel> GetLugaresRecomendados(System.Data.IDbConnection dbConnection);
        List<RecomendacionModel> GetLugareRecomendados();
    }
}
