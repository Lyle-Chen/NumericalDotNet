namespace Calc.Common.AlgebraSystems.Relations.Instances
{
    public interface IEquivalent : IAlgebraicElement
    {
        bool EquivalentTo(IAlgebraicElement oprd);
    }
}
