using Calc.Common.Algebra.Structure.Ring;

namespace Calc.Common.Algebra.Structure.Field
{
    /// <summary>
    /// Field: Commutative Ring which also constitutes an Abelian Group with its opt Times (so that Recp() exists).
    /// </summary>
    public interface IFieldElement : ICommutativeRingElement
    {
        IAlgebraicElement Recp();
    }
}
