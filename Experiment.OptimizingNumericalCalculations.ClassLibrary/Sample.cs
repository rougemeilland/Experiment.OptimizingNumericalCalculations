using System.Numerics;
using System.Runtime.CompilerServices;

namespace Experiment.OptimizingNumericalCalculations.ClassLibrary
{
    public static class Sample
    {
        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveOptimization)]
        public static int Negatve(int x) => -x; // equivalent to "-x"

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveOptimization)]
        public static double Negatve(double x) => -x; // equivalent to "x ^ 0x80000000"

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveOptimization)]
        public static Complex Negatve(Complex x) => -x; // equivalent to "new Complex(x.Real ^ 0x80000000, x.Imaginary ^ 0x80000000)"

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveOptimization)]
        public static int Difference(int x, int y) => -x + y; // equivalent to "y - x"

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveOptimization)]
        public static double Difference(double x, double y) => -x + y; // equivalent to "y - x"

        // equivalent to "new Complex(x.Real ^ 0x80000000 + y, x.Imaginary ^ 0x80000000 + y)"
        // Although this calculation is equivalent to "new Complex(y - x, y - x)", it requires more computational cost.
        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveOptimization)]
        public static Complex Difference(Complex x, Complex y) => -x + y;
    }
}
