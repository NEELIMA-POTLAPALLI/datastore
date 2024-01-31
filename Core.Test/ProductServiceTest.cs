using DataStore.Core.Concrete;
using DataStore.Core.Implementation;
using Moq;
using System.Reflection;

namespace Core.Test
{
    public class ProductServiceTest
    {
        [Fact]
        public void Should_ThrowAnError_WhenBlankCurrencyIsProvided()
        {
            var moqProductService = new Mock<IProductService>();


            Assert.Throws<ArgumentNullException>(() => moqProductService.Object);

        }
    }
}