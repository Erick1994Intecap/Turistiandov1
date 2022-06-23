using Autofac;
using Interface;
using Servicios.Servicios;
using System.Data;
using System.Data.SqlClient;

namespace TurismoHome
{
    public class DIModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LugaresVisitadosService>().As<ILugaresVisitados>().SingleInstance();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Server=35.193.52.85;Database=Turistiando;user=sqlserver;password=R3st@I12022*";
            conn.Open();

            builder.RegisterInstance<IDbConnection>(conn);
        }
    }
}
