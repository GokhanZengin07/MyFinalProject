﻿using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]  // ATTRIBUTE
    public class ProductsController : ControllerBase // API naming must be plural like given in example Products
    {   // LOOSELY Coupled
        // naming convention
        // IoC Container -- Inversion of Control
        IProductService _productService;

        public ProductsController(IProductService productService)

        {
            _productService = productService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        { // Dependency chain --
            // Swagger
            var result=_productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if(result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
    }
}
