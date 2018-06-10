namespace Calc.AlgebraSystems.Structures.Group
{
    /// <summary>
    /// Magma: Algebra with a closed Opt.
    /// </summary>
    public interface IMagmaElement : IAlgebraicElement
    {
        IAlgebraicElement Opt(IAlgebraicElement oprd);
    }
}
