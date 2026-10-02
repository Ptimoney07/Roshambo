using Microsoft.VisualStudio.TestTools.UnitTesting;
// Makes sure the test project can see your Roshambo code
using Roshambo;

[TestClass]
    public class RoshamboTests
    {
        [TestMethod]
        public void DecideWinner_UserBeatsComputer_ReturnsWin()
        {
            // Arrange
            string user = "Rock";
            string computer = "Scissors";

            // Act
            string result = Program.DecideWinner(user, computer);

            // Assert
            Assert.AreEqual("Win", result, "Rock should beat Scissors and return 'Win'.");
        }

        [TestMethod]
        public void DecideWinner_ComputerBeatsUser_ReturnsLose()
        {
            // Arrange
            string user = "Rock";
            string computer = "Paper";

            // Act
            string result = Program.DecideWinner(user, computer);

            // Assert
            Assert.AreEqual("Lose", result, "Rock should lose to Paper and return 'Lose'.");
        }

        [TestMethod]
        public void DecideWinner_SameChoices_ReturnsDraw()
        {
            // Arrange
            string user = "Rock";
            string computer = "Rock";

            // Act
            string result = Program.DecideWinner(user, computer);

            // Assert
            Assert.AreEqual("Draw", result, "Identical choices should return 'Draw'.");
        }
    }

