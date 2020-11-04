using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Solved.Contracts
{
    public interface IFuelReqFromMassCalc
    {
        int OneIteration(decimal mass);

        int Recursive(decimal mass);
    }
}
