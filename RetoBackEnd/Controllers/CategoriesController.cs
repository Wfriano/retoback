namespace RetoBackEnd.Controllers
{
    using Business.Interfaces;
    using Entities;
    using Microsoft.AspNetCore.Mvc;
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesBusiness _categories;
        public CategoriesController(ICategoriesBusiness categories)
        {
            _categories = categories;
        }
        [HttpGet]
        public IEnumerable<Categories> Get()
        {
            return _categories.Get();
        }
        [HttpPost]
        public bool Insertar(Categories category)
        {
            return _categories.Insert(category);
        }
        [HttpPut]
        public bool Actualizar(Categories category)
        {
            return _categories.Update(category);
        }
        [HttpDelete]
        public void Eliminar(int id)
        {
            _categories.Delete(id);
        }
    }
}
