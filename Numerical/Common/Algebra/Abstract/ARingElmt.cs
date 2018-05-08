using Numerical.Common.Algebra.Interface;

namespace Numerical.Common.Algebra.Abstract
{
    /// <summary>
    /// Abstract Ring Element with operators "+", "-", and "*".
    /// </summary>
    public abstract class ARingElmt : IRingElmt
    {
        #region Operators

        public static ARingElmt operator +(ARingElmt left, ARingElmt right)
        {
            return (ARingElmt) left.Plus(right);
        }

        public static ARingElmt operator -(ARingElmt left, ARingElmt right)
        {
            return (ARingElmt) right.Neg().Plus(left);
        }

        public static ARingElmt operator *(ARingElmt left, ARingElmt right)
        {
            return (ARingElmt) left.Times(right);
        }

        #endregion

        #region Operational methods

        public abstract IRingElmt Plus(IRingElmt oprd);

        public abstract IRingElmt Neg();

        public abstract IRingElmt Times(IRingElmt oprd);

        #endregion
    }

    /// <summary>
    /// Abstract Commutative Ring Element with operators "+", "-" and "*".
    /// </summary>
    public abstract class ACommutativeRingElmt : ICommutativeRingElmt
    {
        #region Operators

        public static ACommutativeRingElmt operator +(ACommutativeRingElmt left, ACommutativeRingElmt right)
        {
            return (ACommutativeRingElmt)left.Plus(right);
        }

        public static ACommutativeRingElmt operator -(ACommutativeRingElmt left, ACommutativeRingElmt right)
        {
            return (ACommutativeRingElmt)right.Neg().Plus(left);
        }

        public static ACommutativeRingElmt operator *(ACommutativeRingElmt left, ACommutativeRingElmt right)
        {
            return (ACommutativeRingElmt)left.Times(right);
        }

        #endregion

        #region Operational methods

        IRingElmt IRingElmt.Plus(IRingElmt oprd)
        {
            return Plus(oprd as ICommutativeRingElmt);
        }

        public abstract ICommutativeRingElmt Plus(ICommutativeRingElmt oprd);

        IRingElmt IRingElmt.Neg()
        {
            return Neg();
        }

        public abstract ICommutativeRingElmt Neg();

        IRingElmt IRingElmt.Times(IRingElmt oprd)
        {
            return Times(oprd as ICommutativeRingElmt);
        }

        public abstract ICommutativeRingElmt Times(ICommutativeRingElmt oprd);

        #endregion
    }
}
