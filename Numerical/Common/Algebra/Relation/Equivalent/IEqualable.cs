using Calc.Common.Algebra.Structure;

namespace Calc.Common.Algebra.Relation.Equivalent
{
    public interface IEqualable : IAlgebraicElement
    {
        bool EquivalentTo(IAlgebraicElement oprd);
    }
}
