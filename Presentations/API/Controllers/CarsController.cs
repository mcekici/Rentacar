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
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("getlist")]
        public IActionResult GetCarList()
        {
            var cars = _carService.GetCarDetails();
            return Ok(cars);
        }


        [HttpGet("get")]
        public IActionResult GetCarById(int carId)
        {
            var car = _carService.GetById(carId);
            return Ok(car);
        }


        [HttpPost("add")]
        public IActionResult AddCar(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest();
        }

        [HttpPost("update")]
        public IActionResult UpdateCar(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest();
        }


        [HttpPost("delete")]
        public IActionResult DeleteCar(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest();
        }

    }
}
