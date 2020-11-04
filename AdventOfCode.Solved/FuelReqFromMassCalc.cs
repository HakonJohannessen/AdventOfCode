using AdventOfCode.Solved.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Solved
{
    public class FuelReqFromMassCalc : IFuelReqFromMassCalc
    {
        // puzzle 1
        public int OneIteration(decimal mass) {
            // criteria 1 and 2: divide by 3 and round down
            int fuelRequirement = (int)Math.Floor(mass / 3);
            // criteria 3: subtract 2
            fuelRequirement -= 2;

            return fuelRequirement;
        }

        public int Recursive(decimal mass) {
            decimal remainingMass = mass;
            int fuelRequirement = 0;
            int iterationFuelReq;

            do {
                iterationFuelReq = OneIteration(remainingMass);
                // criteria 1: no negative fuel
                if( iterationFuelReq < 0) {
                    break;
                }
                //criteria 2: mass of fuel is used as mass for next iteration
                remainingMass = iterationFuelReq; 
                fuelRequirement += iterationFuelReq;
            } while (remainingMass > 0);

            return fuelRequirement;
        }
    }
}
