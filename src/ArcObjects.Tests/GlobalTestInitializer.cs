using ArcObjects.Tests.Utilities;
using ESRI.ArcGIS.esriSystem;
using NUnit.Framework;

namespace ArcObjects.Tests
{
    [SetUpFixture]
    public class GlobalTestInitializer
    {
        public static readonly esriLicenseProductCode RequiredProduct = esriLicenseProductCode.esriLicenseProductCodeStandard;

        private static LicenseInitializer m_AOLicenseInitializer = new LicenseInitializer();

        [OneTimeSetUp]
        public void SetUp()
        {
            //ESRI License Initializer generated code.
            m_AOLicenseInitializer.InitializeApplication(
                new esriLicenseProductCode[] { RequiredProduct },
                new esriLicenseExtensionCode[] { }
            );
            //ESRI License Initializer generated code.
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            m_AOLicenseInitializer.ShutdownApplication();
        }
    }
}