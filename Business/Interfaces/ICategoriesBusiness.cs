namespace Business.Interfaces
{
    using Entities;
    public interface ICategoriesBusiness
    {
        bool Insert(Categories categories);
        void Delete(int id);
        bool Update(Categories categories);
        IEnumerable<Categories> Get();
        IEnumerable<Categories> GetById(int id);
    }
}
