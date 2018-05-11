using Calc.Common.AlgebraSystems.Structures;

namespace Calc.Common.AlgebraSystems.Relations.Equivalent
{
    public interface IEqualable : IAlgebraicElement
    {
        bool EquivalentTo(IAlgebraicElement oprd);
    }
}
