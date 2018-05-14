namespace Calc.Common.AlgebraSystems.Structures.Group.Instances.Ring
{
    /// <summary>
    /// Ring: Algebra which constitutes an Abelian Group with its opt Plus (so that Neg() exists), and a Monoid with its opt Times.
    /// Times distributes over Plus.
    /// </summary>
    public interface IRingElement : Additive.IAbelianGroupElement, Multiplicative.IMonoidElement
    {

    }
}
