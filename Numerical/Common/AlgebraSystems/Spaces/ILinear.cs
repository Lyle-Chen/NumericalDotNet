using Calc.Common.AlgebraSystems.Structures.Group.Instance.Field;

namespace Calc.Common.AlgebraSystems.Spaces
{
    /// <summary>
    /// Linear Space: Additive Abelian Group with an operator ScalarTimes to Field Elements.
    /// where:
    /// 1) 1x = x;
    /// 2) (kl)x = k(lx);
    /// 3) (k + l)x = kx + lx;
    /// 4) k(x + y) = kx + ky.
    /// </summary>
    public interface ILinear : Structures.Group.Instance.Additive.IAbelianGroupElement
    {
        IAlgebraicElement ScalarTimes(IFieldElement k);
    }
}
