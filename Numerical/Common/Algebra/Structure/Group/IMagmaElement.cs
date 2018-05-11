namespace Calc.Common.Algebra.Structure.Group
{
    /// <summary>
    /// Magma: Algebra with a closed Opt.
    /// </summary>
    public interface IMagmaElement : IAlgebraicElement
    {
        IAlgebraicElement Opt(IAlgebraicElement oprd);
    }
}
