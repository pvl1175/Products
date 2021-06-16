using Microsoft.VisualStudio.TestTools.UnitTesting;
using Products.Domain;
using Products.Infrastructure;

namespace Products.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SimpleAttribute<int> sa = new SimpleAttribute<int>()
            {
                Name = "SA",
                SystemName = "SYSTEM_SA",
                Value = 100
            };

            SimpleCurrencyAttribute<decimal> sca = new SimpleCurrencyAttribute<decimal>()
            {
                Name = "SCA",
                SystemName = "SYSTEM_SCA",
                Currency = Currency.USD,
                Value = 1000
            };

            SimpleMeasurableAttribute<double> sma = new SimpleMeasurableAttribute<double>()
            {
                Name = "SMA",
                SystemName = "SYSTEM_SMA",
                Unit = UnitOfMeasurement.M1,
                Value = 200.0
            };

            CompoundAttribute ca = new CompoundAttribute();

            ca.Attributes.Add(sa);
            ca.Attributes.Add(sca);
            ca.Attributes.Add(sma);
        }

        [TestMethod]
        public void TestMethod2()
        {
            SimpleAttribute<int> sa = new SimpleAttribute<int>()
            {
                Id = 0,
                Name = "SA",
                SystemName = "SYSTEM_SA",
                Value = 100
            };

            var repo = new AttributeRepository(null);
            repo.AddAttributeAsync<SimpleAttribute<int>>(new Product() { Id = 0, Name = "TestName" }, sa).RunSynchronously();
        }
    }
}