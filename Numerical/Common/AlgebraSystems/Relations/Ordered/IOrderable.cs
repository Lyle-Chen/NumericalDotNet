using Calc.Common.AlgebraSystems.Structures;

namespace Calc.Common.AlgebraSystems.Relations.Ordered
{
    public interface IOrderable : IAlgebraicElement
    {
        bool LessThan(IAlgebraicElement oprd);
    }
}
