using Additive = Calc.AlgebraSystems.Structures.Group.Instances.Additive;
using Multiplicative = Calc.AlgebraSystems.Structures.Group.Instances.Multiplicative;

namespace Calc.AlgebraSystems.Structures.Field
{
    /// <summary>
    /// Field: Commutative Ring which also constitutes an Abelian Group with its opt Times (so that Recp() exists).
    /// </summary>
    public interface IFieldElement : Additive.IAbelianGroupElement, Multiplicative.IAbelianGroupElement
    {

    }
}
