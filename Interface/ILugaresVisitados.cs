using System;
using System.Collections.Generic;
using Turistiando.Model;

namespace Interface
{
    public interface ILugaresVisitados
    {
        LugaresVisitadosModel GetLugareVisitado();
        List<LugaresVisitadosModel> GetLugaresVisitados(System.Data.IDbConnection dbConnection);
        List<LugaresVisitadosModel> GetLugaresVisitados();

    }
}
