namespace Calc.AlgebraSystems.Structures.Group
{
    /// <summary>
    /// Group: Monoid that every element has its invertibility.
    /// </summary>
    public interface IGroupElement : IMonoidElement
    {
        IAlgebraicElement Inv();
    }
}
