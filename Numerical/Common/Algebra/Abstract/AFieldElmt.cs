using Numerical.Common.Algebra.Interface;

namespace Numerical.Common.Algebra.Abstract
{
    /// <summary>
    /// Abstract Field Element with operators "+", "-", "*" and "/".
    /// </summary>
    public abstract class AFieldElmt : IFieldElmt
    {
        #region Operators

        public static AFieldElmt operator +(AFieldElmt left, AFieldElmt right)
        {
            return (AFieldElmt) left.Plus(right);
        }

        public static AFieldElmt operator -(AFieldElmt left, AFieldElmt right)
        {
            return (AFieldElmt) right.Neg().Plus(left);
        }

        public static AFieldElmt operator *(AFieldElmt left, AFieldElmt right)
        {
            return (AFieldElmt) left.Times(right);
        }

        public static AFieldElmt operator /(AFieldElmt left, AFieldElmt right)
        {
            return (AFieldElmt) right.Recp().Times(left);
        }

        #endregion

        #region Operational methods

        IRingElmt IRingElmt.Plus(IRingElmt oprd)
        {
            return Plus(oprd as IFieldElmt);
        }

        ICommutativeRingElmt ICommutativeRingElmt.Plus(ICommutativeRingElmt oprd)
        {
            return Plus(oprd as IFieldElmt);
        }

        public abstract IFieldElmt Plus(IFieldElmt oprd);

        IRingElmt IRingElmt.Neg()
        {
            return Neg();
        }

        ICommutativeRingElmt ICommutativeRingElmt.Neg()
        {
            return Neg();
        }

        public abstract IFieldElmt Neg();

        IRingElmt IRingElmt.Times(IRingElmt oprd)
        {
            return Times(oprd as IFieldElmt);
        }

        ICommutativeRingElmt ICommutativeRingElmt.Times(ICommutativeRingElmt oprd)
        {
            return Times(oprd as IFieldElmt);
        }

        public abstract IFieldElmt Times(IFieldElmt oprd);

        public abstract IFieldElmt Recp();

        #endregion
    }
}
