namespace Calc.Common.Algebra.Structure.Ring
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
            return (ACommutativeRingElement) right.Neg().Plus(left);
        }

        public static ACommutativeRingElement operator *(ACommutativeRingElement left, ACommutativeRingElement right)
        {
            return (ACommutativeRingElement) left.Times(right);
        }

        #endregion

        #region Operational methods

        IRingElement IRingElement.Plus(IRingElement oprd)
        {
            return Plus(oprd as ICommutativeRingElement);
        }

        public abstract ICommutativeRingElement Plus(ICommutativeRingElement oprd);

        IRingElement IRingElement.Neg()
        {
            return Neg();
        }

        public abstract ICommutativeRingElement Neg();

        IRingElement IRingElement.Times(IRingElement oprd)
        {
            return Times(oprd as ICommutativeRingElement);
        }

        public abstract ICommutativeRingElement Times(ICommutativeRingElement oprd);

        #endregion
    }
}
