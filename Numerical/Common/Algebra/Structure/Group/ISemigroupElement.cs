namespace Calc.Common.Algebra.Structure.Group
{
    /// <summary>
    /// Semigroup: Magma who's Opt is also associative.
    /// </summary>
    public interface ISemigroupElement : IMagmaElement
    {
        ISemigroupElement Opt(ISemigroupElement oprd);
    }
}
