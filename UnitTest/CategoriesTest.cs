namespace UnitTest
{
    using Business;
    using Business.Interfaces;
    using Entities;
    using Moq;
    using Repository;
    using System.Linq.Expressions;
    public class CategoriesTest
    {
        private readonly Mock<IUnitOfWork> _mockUnitOfWork;

        public CategoriesTest()
        {
            _mockUnitOfWork = new Mock<IUnitOfWork>();
        }
        [Fact]
        public void GetCategoryTest()
        {
            _mockUnitOfWork.Setup(uow => uow.GenericRepository<Categories>().Get(
                It.IsAny<Expression<Func<Categories, bool>>>(),
                It.IsAny<Func<IQueryable<Categories>, IOrderedQueryable<Categories>>>(),
                It.IsAny<string>()
                )).Returns(new List<Categories>());

            var categoriesBusiness = new CategoriesBusiness(_mockUnitOfWork.Object);
            Assert.NotNull(categoriesBusiness.GetById(1));
        }

        [Fact]
        public void GetAllCategories()
        {
            _mockUnitOfWork.Setup(uow => uow.GenericRepository<Categories>().Get(
                It.IsAny<Expression<Func<Categories, bool>>>(),
                It.IsAny<Func<IQueryable<Categories>, IOrderedQueryable<Categories>>>(),
                It.IsAny<string>()
                )).Returns(new List<Categories>());

            var categoriesBusiness = new CategoriesBusiness(_mockUnitOfWork.Object);
            Assert.NotNull(categoriesBusiness.Get());
        }

        [Fact]
        public void CreateCategory()
        {
            var category = new Categories();
            _mockUnitOfWork.Setup(uow => uow.GenericRepository<Categories>().Insert(category));
            var categoryBusiness = new CategoriesBusiness(_mockUnitOfWork.Object);
            Assert.True(categoryBusiness.Insert(category));
            _mockUnitOfWork.Verify(x => x.Save(), Times.Once);
        }

        [Fact]
        public void UpdateCategory()
        {
            var category = new Categories();
            _mockUnitOfWork.Setup(uow => uow.GenericRepository<Categories>().Update(category));
            var categoriesBusiness = new CategoriesBusiness(_mockUnitOfWork.Object);
            Assert.True(categoriesBusiness.Update(category));
        }
    }
}