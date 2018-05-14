namespace Calc.Common.AlgebraSystems.Relations.Instances
{
    public interface IOrderable : IAlgebraicElement
    {
        bool LessThan(IAlgebraicElement oprd);
    }
}
