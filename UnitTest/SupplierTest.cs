namespace UnitTest
{
    using Business;
    using Business.Interfaces;
    using Entities;
    using Moq;
    using Repository;
    using System.Linq.Expressions;
    public class SupplierTest
    {
        private readonly Mock<IUnitOfWork> _mockUnitOfWork;

        public SupplierTest()
        {
            _mockUnitOfWork = new Mock<IUnitOfWork>();
        }

        [Fact]
        public void GetSupplierTest()
        {
            _mockUnitOfWork.Setup(uow => uow.GenericRepository<Suppliers>().Get(
                It.IsAny<Expression<Func<Suppliers, bool>>>(),
                It.IsAny<Func<IQueryable<Suppliers>, IOrderedQueryable<Suppliers>>>(),
                It.IsAny<string>()
                )).Returns(new List<Suppliers>());

            var supplierBusiness = new SuppliersBusiness(_mockUnitOfWork.Object);
            Assert.NotNull(supplierBusiness.GetById(1));
        }

        [Fact]
        public void GetAllSuppliers()
        {
            _mockUnitOfWork.Setup(uow => uow.GenericRepository<Suppliers>().Get(
                It.IsAny<Expression<Func<Suppliers, bool>>>(),
                It.IsAny<Func<IQueryable<Suppliers>, IOrderedQueryable<Suppliers>>>(),
                It.IsAny<string>()
                )).Returns(new List<Suppliers>());

            var supplierBusiness = new SuppliersBusiness(_mockUnitOfWork.Object);
            Assert.NotNull(supplierBusiness.Get());
        }

        [Fact]
        public void CreateSupplier()
        {
            var supplier = new Suppliers();
            _mockUnitOfWork.Setup(uow => uow.GenericRepository<Suppliers>().Insert(supplier));
            var supplierBusiness = new SuppliersBusiness(_mockUnitOfWork.Object);
            Assert.True(supplierBusiness.Insert(supplier));
            _mockUnitOfWork.Verify(x => x.Save(), Times.Once);
        }

        [Fact]
        public void UpdateSupplier()
        {
            var supplier = new Suppliers();
            _mockUnitOfWork.Setup(uow => uow.GenericRepository<Suppliers>().Update(supplier));
            var supplierBusiness = new SuppliersBusiness(_mockUnitOfWork.Object);
            Assert.True(supplierBusiness.Update(supplier));
        }
    }
}
