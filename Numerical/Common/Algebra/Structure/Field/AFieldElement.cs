using Calc.Common.Algebra.Structure.Ring;

namespace Calc.Common.Algebra.Structure.Field
{
    /// <summary>
    /// Abstract Field Element with operators "+", "-", "*" and "/".
    /// </summary>
    public abstract class AFieldElement : IFieldElement
    {
        #region Operators

        public static AFieldElement operator +(AFieldElement left, AFieldElement right)
        {
            return (AFieldElement)left.Plus(right);
        }

        public static AFieldElement operator -(AFieldElement left, AFieldElement right)
        {
            return (AFieldElement) ((AFieldElement) right.Neg()).Plus(left);
        }

        public static AFieldElement operator *(AFieldElement left, AFieldElement right)
        {
            return (AFieldElement)left.Times(right);
        }

        public static AFieldElement operator /(AFieldElement left, AFieldElement right)
        {
            return (AFieldElement) ((AFieldElement) right.Recp()).Times(left);
        }

        #endregion

        #region Operational methods

        public abstract IAlgebraicElement Plus(IAlgebraicElement oprd);

        public abstract IAlgebraicElement Neg();

        public abstract IAlgebraicElement Times(IAlgebraicElement oprd);

        public abstract IAlgebraicElement Recp();

        #endregion
    }
}
