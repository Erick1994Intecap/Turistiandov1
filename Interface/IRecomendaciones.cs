using System;
using System.Collections.Generic;
using System.Text;
using Turistiando.Model;

namespace Interface
{
    public interface IRecomendaciones
    {
        RecomendacionModel GetLugarRecomendado();
        List<RecomendacionModel> GetLugaresRecomendados(System.Data.IDbConnection dbConnection, string latitud, string longitud);
        List<RecomendacionModel> GetLugareRecomendados();
    }
}
