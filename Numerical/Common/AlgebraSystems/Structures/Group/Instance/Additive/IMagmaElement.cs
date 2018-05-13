namespace Calc.Common.AlgebraSystems.Structures.Group.Instance.Additive
{
    /// <summary>
    /// Additive Magma: Algebra with a closed operator Plus.
    /// </summary>
    public interface IMagmaElement : IAlgebraicElement
    {
        IAlgebraicElement Plus(IAlgebraicElement oprd);
    }
}
