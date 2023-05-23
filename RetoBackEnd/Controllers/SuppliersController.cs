namespace RetoBackEnd.Controllers
{
    using Business.Interfaces;
    using Data;
    using Entities;
    using Microsoft.AspNetCore.Mvc;
    using Repository;
    [ApiController]
    [Route("api/[controller]")]
    public class SuppliersController : ControllerBase
    {
        private readonly ISuppliersBusiness _supplier;
        public SuppliersController(ISuppliersBusiness supplier)
        {
            _supplier = supplier;
        }
        [HttpGet]
        public IEnumerable<Suppliers> Get()
        {
            return _supplier.Get();
        }
        [HttpPost]
        public bool Insertar(Suppliers supplier)
        {
            return _supplier.Insert(supplier);
        }
        [HttpPut]
        public bool Actualizar(Suppliers supplier)
        {
            return _supplier.Update(supplier);
        }
        [HttpDelete]
        public void Eliminar(int id)
        {
            _supplier.Delete(id);
        }
    }
}
