namespace Business.Interfaces
{
    using Entities;
    public interface IProductsBusiness
    {
        bool Insert(Products product);
        void Delete(int id);
        bool Update(Products product);
        IEnumerable<Products> Get();
        IEnumerable<Products> GetById(int id);
    }
}
