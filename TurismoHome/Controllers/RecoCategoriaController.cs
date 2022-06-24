﻿using Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;
using Turistiando.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TurismoHome.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecoCategoriaController : ControllerBase
    {
        private readonly IRecoCategoria _service;
        private readonly IDbConnection _dbConnection;
        public RecoCategoriaController(IRecoCategoria categoria, IDbConnection dbConnection)
        {
            this._service = categoria;
            this._dbConnection = dbConnection;
        }
        // GET: api/<RecoCategoriaController>
        [HttpGet]
        public List<RecoCategoriaModel> Get()
        {
            return _service.GetLugaresCategoria(_dbConnection);
        }

       
    }
}
