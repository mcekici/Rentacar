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
    public class ColorsController : ControllerBase
    {
        IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpGet("getlist")]
        public IActionResult GetColorList()
        {
            var colors = _colorService.GetAll();
            return Ok(colors);
        }


        [HttpGet("get")]
        public IActionResult GetColorById(int colorId)
        {
            var color = _colorService.GetById(colorId);
            return Ok(color);
        }


        [HttpPost("add")]
        public IActionResult AddColor(Color color)
        {
            var result = _colorService.Add(color);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest();
        }

        [HttpPost("update")]
        public IActionResult UpdateColor(Color color)
        {
            var result = _colorService.Update(color);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest();
        }


        [HttpPost("delete")]
        public IActionResult DeleteColor(Color color)
        {
            var result = _colorService.Delete(color);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest();
        }
    }
}
