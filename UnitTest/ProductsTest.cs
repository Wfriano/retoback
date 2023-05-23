namespace UnitTest
{
    using Business;
    using Business.Interfaces;
    using Entities;
    using Moq;
    using Repository;
    using System.Linq.Expressions;
    public class ProductsTest
    {
        private readonly Mock<IUnitOfWork> _mockUnitOfWork;

        public ProductsTest()
        {
            _mockUnitOfWork = new Mock<IUnitOfWork>();
        }

        [Fact]
        public void GetProductTest()
        {
            _mockUnitOfWork.Setup(uow => uow.GenericRepository<Products>().Get(
                It.IsAny<Expression<Func<Products, bool>>>(),
                It.IsAny<Func<IQueryable<Products>, IOrderedQueryable<Products>>>(),
                It.IsAny<string>()
                )).Returns(new List<Products>());

            var productBusiness = new ProductsBusiness(_mockUnitOfWork.Object);
            Assert.NotNull(productBusiness.GetById(1));
        }

        [Fact]
        public void GetAllProducts()
        {
            _mockUnitOfWork.Setup(uow => uow.GenericRepository<Products>().Get(
                It.IsAny<Expression<Func<Products, bool>>>(),
                It.IsAny<Func<IQueryable<Products>, IOrderedQueryable<Products>>>(),
                It.IsAny<string>()
                )).Returns(new List<Products>());

            var productBusiness = new ProductsBusiness(_mockUnitOfWork.Object);
            Assert.NotNull(productBusiness.Get());
        }

        [Fact]
        public void CreateProduct()
        {
            var product = new Products();
            _mockUnitOfWork.Setup(uow => uow.GenericRepository<Products>().Insert(product));
            var productBusiness = new ProductsBusiness(_mockUnitOfWork.Object);
            Assert.True(productBusiness.Insert(product));
            _mockUnitOfWork.Verify(x => x.Save(), Times.Once);
        }

        [Fact]
        public void UpdateProduct()
        {
            var product = new Products();
            _mockUnitOfWork.Setup(uow => uow.GenericRepository<Products>().Update(product));
            var productBusiness = new ProductsBusiness(_mockUnitOfWork.Object);
            Assert.True(productBusiness.Update(product));
        }
    }
}
