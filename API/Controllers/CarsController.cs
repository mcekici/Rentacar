﻿using Business.Abstract;
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

        [HttpGet("getalldto")]
        public IActionResult GetAllDto()
        {
            var cars = _carService.GetAllDto();
            return Ok(cars);
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var cars = _carService.GetAll();
            return Ok(cars);
        }

        [HttpGet("getdto")]
        public IActionResult GetCarById(int carId)
        {
            return Ok(_carService.GetDto(carId));
        }

        [HttpGet("get")]
        public IActionResult Get(int carId)
        {
            return Ok(_carService.Get(carId));
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
