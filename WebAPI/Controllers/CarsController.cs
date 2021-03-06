﻿using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
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

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success) { return Ok(result); }
            return BadRequest();
        }

        [HttpGet("getcardetails")]
        public IActionResult GetCarDetails()
        {
            var result = _carService.GetCarDetails();
            if (result.Success) { return Ok(result); }
            return BadRequest();
        }


        [HttpGet("getcarsbybrand")]
        public IActionResult GetCarsByBrand(string brand)
        {
            var result = _carService.GetCarsByBrand(brand);
            if (result.Success) { return Ok(result); }
            return BadRequest();
        }

        [HttpGet("getcarsbycolor")]
        public IActionResult GetCarsByColor(string color)
        {
            var result = _carService.GetCarsByColor(color);
            if (result.Success) { return Ok(result); }
            return BadRequest();
        }



        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _carService.GetById(id);
            if (result.Success) { return Ok(result); }
            return BadRequest();
        }


        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success) { return Ok(result); }
            return BadRequest();
        }

        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success) { return Ok(result); }
            return BadRequest();
        }
        [HttpPost("update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success) { return Ok(result); }
            return BadRequest();
        
        }
    }
}
