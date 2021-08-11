using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyNLayer.Core.Entitiy_Model_;
using UdemyNLayer.Core.Service;
using UdemyNLayer.DTOS;
using UdemyNLayer.Filters;

namespace UdemyNLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService, IMapper mapper)
        {
            _mapper = mapper;
            _productService = productService;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll()

        {
            var products = await _productService.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<ProductDTO>>(products));
        }
        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet("{id}")]

        public async Task<IActionResult> GetById(int id)
        {
            var product = await _productService.GetByIdAsync(id);

            return Ok(_mapper.Map<ProductDTO>(product));
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpGet("{id}/category")]
        public async Task<IActionResult> GetWithCategoryById(int id)
        {
            var productCategory = await _productService.GetWithCategoryIdAsync(id);

            return Ok(_mapper.Map<ProductWithCategory>(productCategory));
        }

        
        [HttpPost]
        public async Task<IActionResult> Save(ProductDTO productDTO)
        {
            var newProduct = await _productService.AddAsync(_mapper.Map<Products>(productDTO));

            return Created(string.Empty, _mapper.Map<ProductDTO>(newProduct));
        }

        [HttpPut]
        public IActionResult Update(ProductDTO productDTO)
        {
            var product = _productService.Update(_mapper.Map<Products>(productDTO));

            return NoContent();
        }

        [ServiceFilter(typeof(NotFoundFilter))]
        [HttpDelete("{id}")]

        public IActionResult Remove(int id)
        {
             var product = _productService.GetByIdAsync(id).Result;

            _productService.Remove(product);

            return NoContent();
        
        }




 
    }
}
