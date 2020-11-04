using AdventOfCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Solved
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<decimal> moduleMasses = Resources.ModuleMasses.ToList();
            FuelRequirementsCalculator CalculateFuel = new FuelRequirementsCalculator();

            // Puzzle 1: 3432671 units of fuel
            int modulesFuelRequirement = moduleMasses.Select(mass => CalculateFuel.FromMass.OneIteration(mass)).Sum();
            Console.WriteLine(modulesFuelRequirement);

            // Puzzle 1.2: 5146132 units of fuel
            int modulesRecursiveFuelRequirement = moduleMasses.Select(mass => CalculateFuel.FromMass.Recursive(mass)).Sum();
            Console.WriteLine(modulesRecursiveFuelRequirement);

            Console.ReadLine();
        }
    }
}
