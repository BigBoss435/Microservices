﻿using ECommerce.API.Products.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Products.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsProvider productsProvider;

        public ProductsController(IProductsProvider productsProvider) 
        {
            this.productsProvider = productsProvider;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductsAsync()
        {
            var result = await productsProvider.GetProductsAsync();
            if (result.IsSuccess)
            {
                return Ok(result.Products);
            }
            return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductAsync(int id)
        {
            var result = await productsProvider.GetProductsAsync(id);
            if (result.IsSuccess)
            {
                return Ok(result.Product);
            }
            return NotFound();
        }
    }
}
