namespace Calc.AlgebraSystems.Relations.Instances
{
    public interface IEquivalent : IAlgebraicElement
    {
        bool EquivalentTo(IAlgebraicElement oprd);
    }
}
