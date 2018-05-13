using System;

namespace Calc.Common.AlgebraSystems.Spaces
{
    /// <summary>
    /// Normed Space: A set with a function F: Vn |-> R,
    /// where: 
    /// 1) F(Vn) >= 0, F(0) = 0;
    /// 2) F(c*Vn) = |C|*F(Vn);
    /// 3) F(V1) + F(V2) >= F(V1, V2)).
    /// </summary>
    public interface INormed : IAlgebraicElement
    {
        Double Norm();
    }
}
