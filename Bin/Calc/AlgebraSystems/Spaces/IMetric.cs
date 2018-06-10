using System;

namespace Calc.AlgebraSystems.Spaces
{
    /// <summary>
    /// Metric Space: A set with a function D: (x, y) |-> R,
    /// where: 
    /// 1) D(x, y) >= 0, D(x, x) = 0;
    /// 2) D(x, y) = D(y, x);
    /// 3) D(x, y) + D(y, z) >= D(x, z).
    /// </summary>
    public interface IMetric : IAlgebraicElement
    {
        Double DistanceFrom(IAlgebraicElement oprd);
    }
}
