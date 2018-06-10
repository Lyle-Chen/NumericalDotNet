using System;

namespace Calc.AlgebraSystems.Spaces
{
    /// <summary>
    /// Normed Space: A set with a function ||*||: V |-> R,
    /// where: 
    /// 1) ||x|| >= 0, ||0|| = 0;
    /// 2) ||kx|| = |k|*||x|;
    /// 3) ||x|| + ||y|| >= ||x + y||.
    /// </summary>
    public interface INormed : ILinear
    {
        Double Norm();
    }
}
