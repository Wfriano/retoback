namespace Business.Interfaces
{
    using Entities;
    public interface IInventoriesBusiness
    {
        bool Insert(Inventories inventories);
        void Delete(int id);
        bool Update(Inventories inventories);
        IEnumerable<Inventories> Get();
        IEnumerable<Inventories> GetById(int id);
    }
}
