using Business.Interfaces;
using Entities;
using Repository;

namespace Business
{
    public class SuppliersBusiness : ISuppliersBusiness
    {
        private IUnitOfWork _unit;
        public SuppliersBusiness(IUnitOfWork unit)
        {
            this._unit = unit;
        }
        public bool Update(Suppliers suppliers)
        {
            this._unit.GenericRepository<Suppliers>().Update(suppliers);
            return true;
        }

        public void Delete(int id)
        {
            this._unit.GenericRepository<Suppliers>().Delete(id);
        }

        public IEnumerable<Suppliers> GetById(int id)
        {
            return _unit.GenericRepository<Suppliers>().Get(x => x.SupplierId == id).AsEnumerable();
        }

        public bool Insert(Suppliers suppliers)
        {
            this._unit.GenericRepository<Suppliers>().Insert(suppliers);
            return true;
        }

        public IEnumerable<Suppliers> Get()
        {
            return this._unit.GenericRepository<Suppliers>().Get();
        }
    }
}
