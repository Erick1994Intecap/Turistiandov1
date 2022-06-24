using Autofac;
using Interface;
using Servicios.Servicios;
using System.Data;
using System.Data.SqlClient;

namespace TurismoHome
{
    public class DIModule : Autofac.Module
    {
        string connectionString = @"Server=35.193.52.85;Database=Turistiando;user=sqlserver;password=R3st@I12022*";
        
        protected override void Load(ContainerBuilder builder)
        {
            SqlConnection conn;
            #region Lugares Visitados
            builder.RegisterType<LugaresVisitadosService>().As<ILugaresVisitados>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
            #region Lugares Turisticos
            builder.RegisterType<LugarTuristicoService>().As<ILugarTuristico>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
            #region Recomendaciones por Categoria
            builder.RegisterType<RecoCategoriaService>().As<IRecoCategoria>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
            #region Recomendaciones por Lugar Cercano
            builder.RegisterType<RecomendacionesService>().As<IRecomendaciones>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
            #region Recomendaciones por Region
            builder.RegisterType<RecoRegionesService>().As<IRecoRegiones>().SingleInstance();
            conn = new SqlConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            builder.RegisterInstance<IDbConnection>(conn);
            #endregion
        }
    }
}
