using Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;
using Turistiando.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TurismoHome.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LugaresVisitadosController : ControllerBase
    {
        private readonly ILugaresVisitados _service;
        private readonly IDbConnection _dbConnection;

        public LugaresVisitadosController(ILugaresVisitados lugaresVisitados, IDbConnection dbConnection)
        {
            this._service = lugaresVisitados;
            this._dbConnection = dbConnection;
        }

        // GET: api/<LugaresVisitadosController>
        [HttpGet]
        public List<LugaresVisitadosModel> Get()
        {
            return _service.GetLugaresVisitados(_dbConnection);
        }

       
    }
}
