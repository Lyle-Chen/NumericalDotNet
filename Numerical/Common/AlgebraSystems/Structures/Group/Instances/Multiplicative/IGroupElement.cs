namespace Calc.Common.AlgebraSystems.Structures.Group.Instances.Multiplicative
{
    /// <summary>
    /// Multiplicative Group: Multiplicative Monoid that every element (except Zero) has its invertibility Recp.
    /// </summary>
    public interface IGroupElement : IMonoidElement
    {
        IAlgebraicElement Recp();
    }
}
