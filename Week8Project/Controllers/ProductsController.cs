using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week8Project.Core.Dtos;
using Week8Project.Core.Entities;
using Week8Project.Core.Exceptions.Repositories;

namespace Week8Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [Route("api/[controller]")]
        [ApiController]
        public class MainController : ControllerBase
        {
            private readonly IPriceListRepository _priceListRepository;
            private readonly IProductRepository _productRepository;

            public MainController(IPriceListRepository priceListRepository, IProductRepository productRepository)
            {
                _priceListRepository = priceListRepository;
                _productRepository = productRepository;
            }

            [HttpPost("AddPriceList")]
            public async Task<ActionResult> AddPriceList(PricelistAdd pricelist)
            {
                await _priceListRepository.AddPriceList(pricelist);
                return Ok("Success");
            }

            [HttpGet]
            public IEnumerable GetProduct(Guid ProductId)
            {
                return _productRepository.getProduct(ProductId);
            }
        }
    
