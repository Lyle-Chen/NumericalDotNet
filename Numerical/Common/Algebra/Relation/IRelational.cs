using Calc.Common.Algebra.Structure;

namespace Calc.Common.Algebra.Relation
{
    public interface IRelational : IAlgebraicElement
    {
        bool R(IAlgebraicElement oprd);
    }
}
