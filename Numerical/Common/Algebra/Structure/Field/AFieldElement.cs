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
            return (AFieldElement)right.Neg().Plus(left);
        }

        public static AFieldElement operator *(AFieldElement left, AFieldElement right)
        {
            return (AFieldElement)left.Times(right);
        }

        public static AFieldElement operator /(AFieldElement left, AFieldElement right)
        {
            return (AFieldElement)right.Recp().Times(left);
        }

        #endregion

        #region Operational methods

        IRingElement IRingElement.Plus(IRingElement oprd)
        {
            return Plus(oprd as IFieldElement);
        }

        ICommutativeRingElement ICommutativeRingElement.Plus(ICommutativeRingElement oprd)
        {
            return Plus(oprd as IFieldElement);
        }

        public abstract IFieldElement Plus(IFieldElement oprd);

        IRingElement IRingElement.Neg()
        {
            return Neg();
        }

        ICommutativeRingElement ICommutativeRingElement.Neg()
        {
            return Neg();
        }

        public abstract IFieldElement Neg();

        IRingElement IRingElement.Times(IRingElement oprd)
        {
            return Times(oprd as IFieldElement);
        }

        ICommutativeRingElement ICommutativeRingElement.Times(ICommutativeRingElement oprd)
        {
            return Times(oprd as IFieldElement);
        }

        public abstract IFieldElement Times(IFieldElement oprd);

        public abstract IFieldElement Recp();

        #endregion
    }
}
