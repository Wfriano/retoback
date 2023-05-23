namespace UnitTest
{
    using Business;
    using Entities;
    using Moq;
    using Repository;
    using System.Linq.Expressions;
    public class InventoriesTest
    {
        private readonly Mock<IUnitOfWork> _mockUnitOfWork;

        public InventoriesTest()
        {
            _mockUnitOfWork = new Mock<IUnitOfWork>();
        }

        [Fact]
        public void GetInventoryTest()
        {
            _mockUnitOfWork.Setup(uow => uow.GenericRepository<Inventories>().Get(
                It.IsAny<Expression<Func<Inventories, bool>>>(),
                It.IsAny<Func<IQueryable<Inventories>, IOrderedQueryable<Inventories>>>(),
                It.IsAny<string>()
                )).Returns(new List<Inventories>());

            var inventoryBusiness = new InventoriesBusiness(_mockUnitOfWork.Object);
            Assert.NotNull(inventoryBusiness.GetById(1));
        }

        [Fact]
        public void GetAllInventories()
        {
            _mockUnitOfWork.Setup(uow => uow.GenericRepository<Inventories>().Get(
                It.IsAny<Expression<Func<Inventories, bool>>>(),
                It.IsAny<Func<IQueryable<Inventories>, IOrderedQueryable<Inventories>>>(),
                It.IsAny<string>()
                )).Returns(new List<Inventories>());

            var inventoryBusiness = new InventoriesBusiness(_mockUnitOfWork.Object);
            Assert.NotNull(inventoryBusiness.Get());
        }

        [Fact]
        public void CreateCategory()
        {
            var inventory = new Inventories();
            _mockUnitOfWork.Setup(uow => uow.GenericRepository<Inventories>().Insert(inventory));
            var inventoryBusiness = new InventoriesBusiness(_mockUnitOfWork.Object);
            Assert.True(inventoryBusiness.Insert(inventory));
            _mockUnitOfWork.Verify(x => x.Save(), Times.Once);
        }

        [Fact]
        public void UpdateCategory()
        {
            var category = new Inventories();
            _mockUnitOfWork.Setup(uow => uow.GenericRepository<Inventories>().Update(category));
            var inventoryBusiness = new InventoriesBusiness(_mockUnitOfWork.Object);
            Assert.True(inventoryBusiness.Update(category));
        }
    }
}
