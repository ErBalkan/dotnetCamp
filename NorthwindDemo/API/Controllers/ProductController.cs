using AutoMapper;
using Business;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;
    private readonly IMapper _mapper;
    public ProductController(IProductService productService, IMapper mapper)
    {
        _productService = productService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        List<Product> products = _productService.GetAll();
        List<ProductDto> productDtos = _mapper.Map<List<ProductDto>>(products);
        return Ok(productDtos);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        Product product = _productService.GetById(id);
        if (product == null) return NotFound();
        return Ok(product);
    }

    [HttpPost]
    public IActionResult Add(ProductDto productDto)
    {
        Product product = _mapper.Map<Product>(productDto);
        _productService.Add(product);
        return Ok();
    }

    [HttpPut]
    public IActionResult Update(Product product)
    {
        _productService.Update(product);
        return Ok();
    }

    [HttpDelete]
    public IActionResult Delete(Product product)
    {
        _productService.Delete(product);
        return Ok();
    }

}