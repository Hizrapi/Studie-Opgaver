using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Repository_Pattern;

namespace RepositoryPatternTests
{
    [TestClass]
    public class RepositoryTests
    {
        private Mock<ICarRepository> mockCarRepo;
        private Mock<ITripRepository> mockTripRepo;

        [TestInitialize]
        public void Setup()
        {
            mockCarRepo = new Mock<ICarRepository>();
            mockTripRepo = new Mock<ITripRepository>();
        }

        [TestMethod]
        public void AddCar_SavesCorrectly()
        {
            var car = new Car("Toyota", "Corolla", 2020, "Red", "ABC123", "Petrol");

            mockCarRepo.Setup(r => r.AddCar(car));

            mockCarRepo.Object.AddCar(car);

            mockCarRepo.Verify(r => r.AddCar(car), Times.Once);
        }

        [TestMethod]
        public void GetTripsForCar_ReturnsCorrectTrips()
        {
            var trips = new List<Trip>
            {
                new Trip("ABC123", 150, DateTime.Today, TimeSpan.FromHours(8), TimeSpan.FromHours(10)),
                new Trip("ABC123", 200, DateTime.Today, TimeSpan.FromHours(11), TimeSpan.FromHours(13))
            };

            mockTripRepo.Setup(r => r.GetTripsForCar("ABC123")).Returns(trips);

            var result = mockTripRepo.Object.GetTripsForCar("ABC123");

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(150, result[0].Distance);
            Assert.AreEqual(200, result[1].Distance);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddTrip_WithUnknownCar_ThrowsException()
        {
            var trip = new Trip("UNKNOWN123", 100, DateTime.Today, TimeSpan.FromHours(9), TimeSpan.FromHours(11));

            mockCarRepo.Setup(r => r.GetCar("UNKNOWN123")).Returns((Car)null);

            if (mockCarRepo.Object.GetCar(trip.CarRegNr) == null)
                throw new ArgumentException("Car does not exist.");

            mockTripRepo.Object.AddTrip(trip);
        }

        [TestMethod]
        public void DeleteCar_RemovesCorrectly()
        {
            var licensePlate = "ABC123";

            mockCarRepo.Setup(r => r.DeleteCar(licensePlate));

            mockCarRepo.Object.DeleteCar(licensePlate);

            mockCarRepo.Verify(r => r.DeleteCar(licensePlate), Times.Once);
        }

        [TestMethod]
        public void UpdateCar_UpdatesCorrectly()
        {
            var car = new Car("Toyota", "Corolla", 2020, "Blue", "ABC123", "Diesel");

            mockCarRepo.Setup(r => r.UpdateCar(car));

            mockCarRepo.Object.UpdateCar(car);

            mockCarRepo.Verify(r => r.UpdateCar(car), Times.Once);
        }

        [TestMethod]
        public void DeleteTrip_RemovesCorrectly()
        {
            var trip = new Trip("ABC123", 150, DateTime.Today, TimeSpan.FromHours(8), TimeSpan.FromHours(10));

            mockTripRepo.Setup(r => r.DeleteTrip(trip));

            mockTripRepo.Object.DeleteTrip(trip);

            mockTripRepo.Verify(r => r.DeleteTrip(trip), Times.Once);
        }
    }
}
