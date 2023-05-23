namespace RetoBackEnd.Controllers
{
    using Business.Interfaces;
    using Entities;
    using Microsoft.AspNetCore.Mvc;
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsBusiness _products;
        public ProductsController(IProductsBusiness products)
        {
            _products = products;
        }
        [HttpGet]
        public IEnumerable<Products> Get()
        {
            return _products.Get();
        }
        [HttpPost]
        public bool Insertar(Products product)
        {
            return _products.Insert(product);
        }
        [HttpPut]
        public bool Actualizar(Products product)
        {
            return _products.Update(product);
        }
        [HttpDelete]
        public void Eliminar(int id)
        {
            _products.Delete(id);
        }
    }
}
