using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    public class ReservationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CanBeCancelledBy_AdminUserCancellingReservation_ReturnsTrue()
        {
            // Arrange
            Reservation reservation = new Reservation();

            // Act
            bool result = reservation.CanBeCancelledBy(new User() { IsAdmin = true });

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellingReservation_ReturnsTrue()
        {
            // Arrange
            User user = new User();
            Reservation reservation = new Reservation() { MadeBy = user };

            // Act
            bool result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnsFalse()
        {
            // Arrange
            Reservation reservation = new Reservation() { MadeBy = new User() };

            // Act
            bool result = reservation.CanBeCancelledBy(new User());

            // Assert
            Assert.That(result, Is.False);
        }
    }
}