namespace Business.Interfaces
{
    using Entities;
    public interface ISuppliersBusiness
    {
        bool Insert(Suppliers suppliers);
        void Delete(int id);
        bool Update(Suppliers suppliers);
        IEnumerable<Suppliers> Get();
        IEnumerable<Suppliers> GetById(int id);
    }
}
