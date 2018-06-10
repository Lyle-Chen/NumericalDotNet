namespace Calc.AlgebraSystems.Relations.Instances
{
    public interface IOrderable : IAlgebraicElement
    {
        bool LessThan(IAlgebraicElement oprd);
    }
}
