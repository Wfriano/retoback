namespace RetoBackEnd.Controllers
{
    using Business.Interfaces;
    using Entities;
    using Microsoft.AspNetCore.Mvc;
    [ApiController]
    [Route("api/[controller]")]
    public class InventoriesController : ControllerBase
    {
        private readonly IInventoriesBusiness _inventories;
        public InventoriesController(IInventoriesBusiness inventories)
        {
            _inventories = inventories;
        }
        [HttpGet]
        public IEnumerable<Inventories> Get()
        {
            return _inventories.Get();
        }
        [HttpPost]
        public bool Insertar(Inventories inventory)
        {
            return _inventories.Insert(inventory);
        }
        [HttpPut]
        public bool Actualizar(Inventories inventory)
        {
            return _inventories.Update(inventory);
        }
        [HttpDelete]
        public void Eliminar(int id)
        {
            _inventories.Delete(id);
        }
    }
}
