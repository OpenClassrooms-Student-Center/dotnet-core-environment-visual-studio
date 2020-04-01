using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HelloWorld.Tests
{
    [TestClass]
    public class CheckingAccountTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Withdraw_AmountMoreThanBalance_Throws()
        {
            // Arrange
            var account = new CheckingAccount("John Doe", 10.0);

            // Act
            account.Withdraw(20.0);

            // Assert
            // Handled by ExpectedException header
        }

        [TestMethod]
        public void Withdraw_ValidAmount_ChangesBalance()
        {
            // Arrange
            double currentBalance = 10.0;
            double withdrawal = 1.0;
            double expected = 9.0;
            var account = new CheckingAccount("JohnDoe", currentBalance);

            // Act
            account.Withdraw(withdrawal);
            double actual = account.Balance;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
