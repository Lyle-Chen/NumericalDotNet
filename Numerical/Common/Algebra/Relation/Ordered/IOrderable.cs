using Calc.Common.Algebra.Structure;

namespace Calc.Common.Algebra.Relation.Ordered
{
    public interface IOrderable : IAlgebraicElement
    {
        bool LessThan(IAlgebraicElement oprd);
    }
}
