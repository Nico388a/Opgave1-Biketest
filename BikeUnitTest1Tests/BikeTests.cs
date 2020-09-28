using Microsoft.VisualStudio.TestTools.UnitTesting;
using BikeUnitTest1;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeUnitTest1.Tests
{
    [TestClass()]
    public class BikeTests
    {
        private Bike _bike;

        [TestInitialize]
        public void Infit()
        {
            _bike = new Bike(1, "Green", 3, 500);
        }

        [TestMethod()]
        public void IdTest()
        {
            //Arrange/Act
            _bike.Id = 1;

            //Assert
            Assert.AreEqual(1, _bike.Id);
        }


        [TestMethod()]
        public void Color()
        {
            //Arrange/Act
            _bike.Color = "Green";

            //Assert
            Assert.AreEqual("Green", _bike.Color);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _bike.Color = "");
            Assert.ThrowsException<ArgumentNullException>(() => _bike.Color = null);
        }

        [TestMethod]
        public void Gear()
        {
            //Arrange/Act
            _bike.Gear = 3;


            //Assert
            Assert.AreEqual(3, _bike.Gear);

            _bike.Gear = 32;
            Assert.AreEqual(32, _bike.Gear);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _bike.Gear = 2);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _bike.Gear = 33);
        }

        [TestMethod]
        public void Price()
        {
            //Arrange/Act
            _bike.Price = 250;

            //Assert
            Assert.AreEqual(250, _bike.Price);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _bike.Price = -1);

        }

        [TestMethod]

        public void ConstructorTest()
        {
            //Arrange
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Bike(1, "", 4, 50));

            Bike b = new Bike(1, "B", 5, 85);

            Assert.AreEqual("B", b.Color);
        }
    }
}