using AdventOfCode.Solved.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Solved
{
    public class FuelRequirementsCalculator : IFuelRequirementCalculator
    {
        private IFuelReqFromMassCalc _fromMass;

        public FuelRequirementsCalculator() {
            _fromMass = new FuelReqFromMassCalc();
        }

        public IFuelReqFromMassCalc FromMass { get => _fromMass; }
    }
}
