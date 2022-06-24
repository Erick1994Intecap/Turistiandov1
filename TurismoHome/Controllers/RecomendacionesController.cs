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
    public class RecomendacionesController : ControllerBase
    {
        private readonly IRecomendaciones _service;
        private readonly IDbConnection _dbConnection;
        public RecomendacionesController(IRecomendaciones lugar, IDbConnection dbConnection)
        {
            this._service = lugar;
            this._dbConnection = dbConnection;
        }
        // GET: api/<RecomendacionesController>
        [HttpGet]
        public List<RecomendacionModel> Get()
        {
            return _service.GetLugaresRecomendados(_dbConnection);
        }

        // GET api/<RecomendacionesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        
    }
}