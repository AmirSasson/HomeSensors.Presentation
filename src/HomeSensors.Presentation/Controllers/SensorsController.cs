﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using HomeSensors.Presentation.Contracts;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeSensors.Presentation.Controllers
{
    [Route("api/[controller]")]
    public class SensorsController : Controller
    {
        [FromServices]
        public ISensorsService _sensorService { get; set; }


        // GET: api/values
        [HttpGet]
        [Produces(contentType: "application/json")]
        public IEnumerable<SensorData<double>> Get()
        {
            return _sensorService.GetSnapshot();
        }

        // GET: api/values
        [HttpGet("api/[controller]/GetSensors")]
        [Produces(contentType: "application/json")]
        public IEnumerable<Sensor> GetSensors()
        {
            return null;
        }


        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
