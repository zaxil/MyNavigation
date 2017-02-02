using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyNavigation.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MyNavigation.Tests.Controllers
{
    [TestClass]
    public class MapControllerTest
    {
        [TestMethod]
        public void CheckMap()
        {
            MapController mapController = new MapController();
            ViewResult viewResult = mapController.Index() as ViewResult;
            Assert.IsNotNull(viewResult);
        }
    }
}
