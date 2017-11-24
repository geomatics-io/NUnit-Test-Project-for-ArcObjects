using System;
using ArcObjects.Tests.Utilities;
using ESRI.ArcGIS.esriSystem;
using NUnit.Framework;

namespace ArcObjects.Tests.Tests
{
    [TestFixture]
    public class DefaultTests : AbstractTestFixure
    {
        [SetUp]
        public void SetUp()
        {

        }

        [TearDown]
        public void TearDown()
        {

        }

        [Test]
        public void LicenseShouldBeAvailableAndAvailableLicenseShouldBeHigherOrEqualThanNeededLicense()
        {
            IAoInitialize aoInitTestProduct = new AoInitializeClass();
            esriLicenseProductCode prodCode = aoInitTestProduct.InitializedProduct();

            Assert.IsTrue(prodCode >= GlobalTestInitializer.RequiredProduct);
        }
    }
}