namespace Calc.Common.Algebra.Structure.Ring
{
    /// <summary>
    /// Abstract Ring Element with operators "+", "-", and "*".
    /// </summary>
    public abstract class ARingElement : IRingElement
    {
        #region Operators

        public static ARingElement operator +(ARingElement left, ARingElement right)
        {
            return (ARingElement) left.Plus(right);
        }

        public static ARingElement operator -(ARingElement left, ARingElement right)
        {
            return (ARingElement) right.Neg().Plus(left);
        }

        public static ARingElement operator *(ARingElement left, ARingElement right)
        {
            return (ARingElement) left.Times(right);
        }

        #endregion

        #region Operational methods

        public abstract IRingElement Plus(IRingElement oprd);

        public abstract IRingElement Neg();

        public abstract IRingElement Times(IRingElement oprd);

        #endregion
    }
}
