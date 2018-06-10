using Additive = Calc.AlgebraSystems.Structures.Group.Instances.Additive;
using Multiplicative = Calc.AlgebraSystems.Structures.Group.Instances.Multiplicative;

namespace Calc.AlgebraSystems.Structures.Ring
{
    /// <summary>
    /// Ring: Algebra which constitutes an Abelian Group with its opt Plus (so that Neg() exists), and a Monoid with its opt Times.
    /// Times distributes over Plus.
    /// </summary>
    public interface IRingElement : Additive.IAbelianGroupElement, Multiplicative.IMonoidElement
    {

    }
}
