﻿using CatalogService.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogService.Controllers
{
    [Route("api/catalog")]
    public class CatalogController : Controller
    {
        private ICatalogService _icatalogService;
        private readonly IRabitMQProducer _irabitMQProducer;
        public CatalogController(ICatalogService icatalogService, IRabitMQProducer irabitMQProducer)
        {
            _icatalogService = icatalogService;
            _irabitMQProducer = irabitMQProducer;
        }
        [Produces("application/json")]
        [HttpGet("findall")]
        public IActionResult Index()
        {
            try
            {
                //This comment is added from master branch
                // New commit from master
                // this is for feature branch
                _irabitMQProducer.SendProductMessage(_icatalogService.FindAll());
                return Ok(_icatalogService.FindAll());
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
