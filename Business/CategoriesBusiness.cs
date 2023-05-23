namespace Business
{
    using Business.Interfaces;
    using Entities;
    using Repository;
    public class CategoriesBusiness : ICategoriesBusiness
    {
        private IUnitOfWork _unit;
        public CategoriesBusiness(IUnitOfWork unit)
        {
            this._unit = unit;
        }
        public bool Update(Categories categories)
        {
            this._unit.GenericRepository<Categories>().Update(categories);
            return true;
        }

        public void Delete(int id)
        {
            this._unit.GenericRepository<Categories>().Delete(id);
        }

        public IEnumerable<Categories> GetById(int id)
        {
            return _unit.GenericRepository<Categories>().Get(x => x.CategoryId == id).AsEnumerable();
        }

        public bool Insert(Categories categories)
        {
            this._unit.GenericRepository<Categories>().Insert(categories);
            return true;
        }

        public IEnumerable<Categories> Get()
        {
            return this._unit.GenericRepository<Categories>().Get();
        }
    }
}
