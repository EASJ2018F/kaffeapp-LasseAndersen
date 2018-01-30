using Microsoft.VisualStudio.TestTools.UnitTesting;
using kaffe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe.Tests
{
    [TestClass()]
    public class FlatWhiteTests
    {
        [TestMethod()]
        public void MlMælkTest()
        {

            // Arrange
            var Mælk = new FlatWhite();

            // Act

            int Ml = Mælk.MlMælk();

            //Assert
            Assert.AreEqual(160, Ml);
        }

        [TestMethod()]
        public void PrisTest()
        {

            // Arrange
            var prisPåFlatWhite = new FlatWhite();

            //Act

            var pris = prisPåFlatWhite.Pris();
            
            //Assert

            Assert.AreEqual(45, pris);
        }

        [TestMethod()]
        public void StyrkeTest()
        {
            // Arrange
            var flatWhiteStyrke = new FlatWhite();

            //Act

            var Styrke = flatWhiteStyrke.Styrke();

            //Assert

            Assert.AreEqual("mild", Styrke);
        }
    }
}