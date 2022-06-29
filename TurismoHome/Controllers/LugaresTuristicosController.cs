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
    public class LugaresTuristicosController : ControllerBase
    {
        private readonly ILugarTuristico _service;
        private readonly IDbConnection _dbConnection;
        public LugaresTuristicosController(ILugarTuristico lugar, IDbConnection dbConnection)
        {
            this._service = lugar;
            this._dbConnection = dbConnection;
        }
        // GET: api/<LugaresTuristicosController>
        [HttpGet]
        public List<LugarTursiticoModel> Get()
        {
            return _service.GetLugaresTuristicos(_dbConnection);
        }

       
        // PUT api/<LugaresTuristicosController>/5
        [HttpPut("{id}")]
        public List<LugarTursiticoModel> Put(int id)
        {
            return _service.EditLugar(_dbConnection, id);
        }

    }
}
