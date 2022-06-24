using System;
using System.Collections.Generic;
using System.Text;
using Turistiando.Model;

namespace Interface
{
    public interface IRecoCategoria
    {
        RecoCategoriaModel GetLugaresCategoria();
        List<RecoCategoriaModel> GetLugaresCategoria(System.Data.IDbConnection dbConnection);
        List<RecoCategoriaModel> GetLugarCategoria();
    }
}
