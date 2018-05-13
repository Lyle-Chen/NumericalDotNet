namespace Calc.Common.AlgebraSystems.Structures.Group.Instance.Ring
{
    /// <summary>
    /// Abstract Commutative Ring Element with operators "+", "-" and "*".
    /// </summary>
    public abstract class ACommutativeRingElement : ICommutativeRingElement
    {
        #region Operators

        public static ACommutativeRingElement operator +(ACommutativeRingElement left, ACommutativeRingElement right)
        {
            return (ACommutativeRingElement) left.Plus(right);
        }

        public static ACommutativeRingElement operator -(ACommutativeRingElement left, ACommutativeRingElement right)
        {
            return (ACommutativeRingElement) ((ACommutativeRingElement) right.Neg()).Plus(left);
        }

        public static ACommutativeRingElement operator *(ACommutativeRingElement left, ACommutativeRingElement right)
        {
            return (ACommutativeRingElement) left.Times(right);
        }

        #endregion

        #region Operational methods

        public abstract IAlgebraicElement Plus(IAlgebraicElement oprd);

        public abstract IAlgebraicElement Neg();

        public abstract IAlgebraicElement Times(IAlgebraicElement oprd);

        #endregion
    }
}
