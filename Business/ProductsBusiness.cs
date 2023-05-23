namespace Business
{
    using Business.Interfaces;
    using Entities;
    using Repository;
    public class ProductsBusiness : IProductsBusiness
    {
        private IUnitOfWork _unit;
        public ProductsBusiness(IUnitOfWork unit)
        {
            this._unit = unit;
        }
        public bool Update(Products product)
        {
            this._unit.GenericRepository<Products>().Update(product);
            return true;
        }

        public void Delete(int id)
        {
            this._unit.GenericRepository<Products>().Delete(id);
        }

        public IEnumerable<Products> GetById(int id)
        {
            return _unit.GenericRepository<Products>().Get(x => x.ProductId == id).AsEnumerable();
        }

        public bool Insert(Products product)
        {
            this._unit.GenericRepository<Products>().Insert(product);
            return true;
        }

        public IEnumerable<Products> Get()
        {
            return this._unit.GenericRepository<Products>().Get();
        }
    }
}
