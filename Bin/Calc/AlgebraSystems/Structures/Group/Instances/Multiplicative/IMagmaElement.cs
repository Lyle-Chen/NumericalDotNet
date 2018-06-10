namespace Calc.AlgebraSystems.Structures.Group.Instances.Multiplicative
{
    /// <summary>
    /// Multiplicative Magma: Algebra with a closed operator Times.
    /// </summary>
    public interface IMagmaElement : IAlgebraicElement
    {
        IAlgebraicElement Times(IAlgebraicElement oprd);
    }
}
