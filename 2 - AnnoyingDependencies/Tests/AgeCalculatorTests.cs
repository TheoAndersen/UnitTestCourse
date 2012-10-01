using System;
using _2___AnnoyingDependencies;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class AgeCalculatorTests
    {
        [TestMethod]
        public void AgeCalculator_CalculatesTheRightNumberOfDays()
        {
            AgeCalculator ageCalculator = new AgeCalculator();

            ageCalculator.CalculateAgeInDays("31/03/1981");
        }
    }
}

/* Steps in getting it to unit test
 * 
 * 1. Write the unit test as should would like the code to be
 * 
 * 2. Refactor it so it compiles
 * 
 * 3. Extract the dendencies you need to stub/mock
 * 
 * 4. Make the test pass
 * 
 */
