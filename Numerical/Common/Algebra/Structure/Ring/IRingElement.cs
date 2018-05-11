namespace Calc.Common.Algebra.Structure.Ring
{
    /// <summary>
    /// Ring: Algebra which constitutes an Abelian Group with its opt Plus (so that Neg() exists), and a Monoid with its opt Times, where Times distributes over Plus.
    /// </summary>
    public interface IRingElement : IAlgebraicElement
    {
        IAlgebraicElement Plus(IAlgebraicElement oprd);

        IAlgebraicElement Neg();

        IAlgebraicElement Times(IAlgebraicElement oprd);
    }
}
