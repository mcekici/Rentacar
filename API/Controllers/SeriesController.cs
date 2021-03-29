using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeriesController : ControllerBase
    {
        ISerialService _serialService;

        public SeriesController(ISerialService serialService)
        {
            _serialService = serialService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var series = _serialService.GetAll();
            return Ok(series);
        }


        [HttpGet("get")]
        public IActionResult GetSerialById(int serialId)
        {
            var serial = _serialService.GetById(serialId);
            return Ok(serial);
        }


        [HttpPost("add")]
        public IActionResult AddSerial(Serial serial)
        {
            var result = _serialService.Add(serial);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest();
        }

        [HttpPost("update")]
        public IActionResult UpdateSerial(Serial serial)
        {
            var result = _serialService.Update(serial);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest();
        }


        [HttpPost("delete")]
        public IActionResult DeleteSerial(Serial serial)
        {
            var result = _serialService.Delete(serial);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest();
        }
    }
}
