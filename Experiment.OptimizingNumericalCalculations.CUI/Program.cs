using System.Numerics;
using Experiment.OptimizingNumericalCalculations.ClassLibrary;
namespace Experiment.OptimizingNumericalCalculations.CUI
{
    internal sealed class Program
    {
        private static void Main()
        {
            _ = Sample.Negatve(1);
            _ = Sample.Negatve(1d);
            _ = Sample.Negatve(Complex.One);
            _ = Sample.Difference(1, -1);
            _ = Sample.Difference(1d, -1d);
            _ = Sample.Difference(Complex.One, Complex.ImaginaryOne);
        }
    }
}
