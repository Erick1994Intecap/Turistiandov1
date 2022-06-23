using System;
using System.Collections.Generic;
using System.Text;
using Turistiando.Model;

namespace Interface
{
    public interface ILugarTuristico
    {
        LugarTursiticoModel GetLugareVisitado();
        List<LugarTursiticoModel> GetLugaresVisitados(System.Data.IDbConnection dbConnection);
        List<LugarTursiticoModel> GetLugaresVisitados();
        void EditAlumno(LugarTursiticoModel alumno);
    }
}
