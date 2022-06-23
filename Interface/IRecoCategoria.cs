using System;
using System.Collections.Generic;
using System.Text;
using Turistiando.Model;

namespace Interface
{
    public interface IRecoCategoria
    {
        RecoCategoriaModel GetLugareVisitado();
        List<RecoCategoriaModel> GetLugaresVisitados(System.Data.IDbConnection dbConnection);
        List<RecoCategoriaModel> GetLugaresVisitados();
    }
}
