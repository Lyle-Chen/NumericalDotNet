namespace Calc.AlgebraSystems.Structures.Ring
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
            return (ARingElement) ((ARingElement) right.Neg()).Plus(left);
        }

        public static ARingElement operator *(ARingElement left, ARingElement right)
        {
            return (ARingElement) left.Times(right);
        }

        #endregion

        #region Operational methods

        public abstract IAlgebraicElement Plus(IAlgebraicElement oprd);

        public abstract IAlgebraicElement Neg();

        public abstract IAlgebraicElement Times(IAlgebraicElement oprd);

        #endregion
    }
}
