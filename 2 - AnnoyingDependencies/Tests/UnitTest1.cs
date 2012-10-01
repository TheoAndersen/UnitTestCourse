using System;
using _2___AnnoyingDependencies;
using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AgeCalculator_CalculatesTheRightNumberOfDays_RhinoMock()
        {
            var logMock = MockRepository.GenerateMock<ILog>();
            logMock.Expect(l => l.Info(Arg<string>.Is.Anything)).Repeat.Twice();
            DateTime now = new DateTime(1981, 4, 1);
            AgeCalculator ageCalculator = new AgeCalculator(logMock, now);

            ageCalculator.CalculateAgeInDays("31/03/1981");


            var arguments = logMock.GetArgumentsForCallsMadeOn(l => l.Info(null));
            Assert.AreEqual(2, arguments.Count, "two calls was made to Info()");
            Assert.AreEqual("You entered your birthday as: 31-03-1981", arguments[0][0]);
            Assert.AreEqual("1 days have passed since that day.", arguments[1][0]);
            logMock.VerifyAllExpectations();
        }

        [TestMethod]
        public void TestArrangeActAssert()
        {
            //Arrange
            AnswerFinder target = new AnswerFinder();

            //Act
            int answer = target.FindTheAnswer();

            //Assert
            Assert.AreEqual(42, answer);
        }

        class AnswerFinder
        {
        }
    }
}
