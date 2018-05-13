namespace Calc.Common.AlgebraSystems.Relations.Instance
{
    public interface IOrderable : IAlgebraicElement
    {
        bool LessThan(IAlgebraicElement oprd);
    }
}
