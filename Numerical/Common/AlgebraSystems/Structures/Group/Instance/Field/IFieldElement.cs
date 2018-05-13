namespace Calc.Common.AlgebraSystems.Structures.Group.Instance.Field
{
    /// <summary>
    /// Field: Commutative Ring which also constitutes an Abelian Group with its opt Times (so that Recp() exists).
    /// </summary>
    public interface IFieldElement : Additive.IAbelianGroupElement, Multiplicative.IAbelianGroupElement
    {

    }
}
