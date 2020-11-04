using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Solved.Contracts
{
    public interface IFuelRequirementCalculator
    {
        public IFuelReqFromMassCalc FromMass { get; }
    }
}
