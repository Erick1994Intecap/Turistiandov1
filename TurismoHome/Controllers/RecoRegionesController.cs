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
    public class RecoRegionesController : ControllerBase
    {
        private readonly IRecoRegiones _service;
        private readonly IDbConnection _dbConnection;
        public RecoRegionesController(IRecoRegiones lugar, IDbConnection dbConnection)
        {
            this._service = lugar;
            this._dbConnection = dbConnection;
        }
        // GET: api/<RecoRegionesController>
        [HttpGet]
        public List<RecoRegionModel> Get()
        {
            return _service.GetRecomendacionesRegiones(_dbConnection);
        }

        // GET api/<RecoRegionesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RecoRegionesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RecoRegionesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RecoRegionesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
