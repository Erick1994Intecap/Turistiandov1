using System;
using System.Collections.Generic;
using System.Text;
using Turistiando.Model;

namespace Interface
{
    public interface ILugarTuristico
    {
        LugarTursiticoModel GetLugaresTuristico();
        List<LugarTursiticoModel> GetLugaresTuristicos(System.Data.IDbConnection dbConnection);
        List<LugarTursiticoModel> GetLugaresTuristicos();
        void EditLugar(LugarTursiticoModel lugar);
    }
}
