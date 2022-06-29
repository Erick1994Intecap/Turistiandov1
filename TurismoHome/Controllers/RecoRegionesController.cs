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

        [HttpGet("lugarByRegionName")]
        public List<RecoRegionModel> GetSiteRegion(string region)
        {
            return _service.GetRecomendacionesRegiones(_dbConnection, region);
        }


    }
}
