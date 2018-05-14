namespace Calc.Common.AlgebraSystems.Structures.Group.Instances.Additive
{
    /// <summary>
    /// Additive Group: Additive Monoid that every element has its invertibility Neg.
    /// </summary>
    public interface IGroupElement : IMonoidElement
    {
        IAlgebraicElement Neg();
    }
}
