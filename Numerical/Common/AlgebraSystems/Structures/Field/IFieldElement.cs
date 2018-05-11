using Calc.Common.AlgebraSystems.Structures.Ring;

namespace Calc.Common.AlgebraSystems.Structures.Field
{
    /// <summary>
    /// Field: Commutative Ring which also constitutes an Abelian Group with its opt Times (so that Recp() exists).
    /// </summary>
    public interface IFieldElement : ICommutativeRingElement
    {
        IAlgebraicElement Recp();
    }
}
