using System;
using _5_11_TestingTheInteractionBetweenTwoObjects.Mocking;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class OrderServiceTests
    {
        [Test]
        public void PlaceOrder_WhenCalled_StoreTheOrder()
        {
            var storage = new Mock<IStorage>();
            var service = new OrderService(storage.Object);

            var order = new Order();
            service.PlaceOrder(order);

            storage.Verify(s => s.Store(order));
        }

    }
}
