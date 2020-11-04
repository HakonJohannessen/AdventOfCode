using AdventOfCode.Solved.Contracts;
using NUnit.Framework;

namespace AdventOfCode.Solved.Tests
{
    public class FuelReqFromMassCalcTests
    {
        private IFuelReqFromMassCalc CalculateFuelFromMass;

        [SetUp]
        public void Setup() 
        {
            CalculateFuelFromMass = new FuelReqFromMassCalc();
        }

        [TestCase(12, ExpectedResult = 2)]
        [TestCase(14, ExpectedResult = 2)]
        [TestCase(1969, ExpectedResult = 654)]
        [TestCase(100756, ExpectedResult = 33583)]
        public int CalculateFuelFromMass_Basic_Test(decimal mass) {
            return CalculateFuelFromMass.OneIteration(mass);
        }

        [TestCase(14, ExpectedResult = 2)]
        [TestCase(1969, ExpectedResult = 966)]
        [TestCase(100756, ExpectedResult = 50346)]
        public int CalculateFuelFromMass_Recursive_Test(decimal mass) {
            return CalculateFuelFromMass.Recursive(mass);
        }
    }
}