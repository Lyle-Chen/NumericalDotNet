namespace Calc.Common.AlgebraSystems.Relations.Instance
{
    public interface IEquivalent : IAlgebraicElement
    {
        bool EquivalentTo(IAlgebraicElement oprd);
    }
}
