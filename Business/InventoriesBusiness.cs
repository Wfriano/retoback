namespace Business
{
    using Business.Interfaces;
    using Entities;
    using Repository;
    using System.Linq;
    public class InventoriesBusiness : IInventoriesBusiness
    {
        private IUnitOfWork _unit;
        public InventoriesBusiness(IUnitOfWork unit)
        {
            this._unit = unit;
        }
        public bool Update(Inventories inventories)
        {
            this._unit.GenericRepository<Inventories>().Update(inventories);
            return true;
        }

        public void Delete(int id)
        {
            this._unit.GenericRepository<Inventories>().Delete(id);
        }

        public IEnumerable<Inventories> GetById(int id)
        {
            return _unit.GenericRepository<Inventories>().Get(x => x.InventoryId == id).AsEnumerable();
        }

        public bool Insert(Inventories inventories)
        {
            this._unit.GenericRepository<Inventories>().Insert(inventories);
            return true;
        }

        public IEnumerable<Inventories> Get()
        {
            return this._unit.GenericRepository<Inventories>().Get();
        }
    }
}
