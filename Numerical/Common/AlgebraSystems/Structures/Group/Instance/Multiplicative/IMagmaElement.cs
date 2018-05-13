namespace Calc.Common.AlgebraSystems.Structures.Group.Instance.Multiplicative
{
    /// <summary>
    /// Multiplicative Magma: Algebra with a closed operator Times.
    /// </summary>
    public interface IMagmaElement : IAlgebraicElement
    {
        IAlgebraicElement Times(IAlgebraicElement oprd);
    }
}
