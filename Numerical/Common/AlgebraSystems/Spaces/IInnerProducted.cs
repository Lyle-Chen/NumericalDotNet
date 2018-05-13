using Calc.Common.AlgebraSystems.Structures.Group.Instance.Field;

namespace Calc.Common.AlgebraSystems.Spaces
{
    /// <summary>
    /// Inner Product Space: A Linear Space with the Dot operator: (*, *),
    /// where:
    /// 1) (x, x) >= 0, (0, 0) = 0;
    /// 2) (x, y) = conj[(y, x)];
    /// 3) (x + y, z) = (x, z) + (y, z), (kx, y) = k(x, y).
    /// </summary>
    public interface IInnerProducted : ILinear
    {
        IFieldElement Dot(IAlgebraicElement oprd);
    }
}
