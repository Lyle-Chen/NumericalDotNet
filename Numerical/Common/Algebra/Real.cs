using Numerical.Common.Algebra.Interface;

namespace Numerical.Common.Algebra
{
    public class Real : IFieldElmt
    {
        private static readonly Real One = new Real(1.0);
        private static readonly Real Zero = new Real(0.0);

        public double Val { get; set; }

        public Real(double x)
        {
            Val = x;
        }

        public Real() : this(0.0)
        {

        }

        public static Real O
        {
            get { return Zero; }
        }

        public static Real I
        {
            get { return One; }
        }

        // Operators

        public static Real operator +(Real left, Real right)
        {
            return (Real) left.Plus(right);
        }

        public static Real operator -(Real left, Real right)
        {
            return (Real) left.Minus(right);
        }

        public static Real operator *(Real left, Real right)
        {
            return (Real)left.Times(right);
        }

        public static Real operator /(Real left, Real right)
        {
            return (Real)left.DivBy(right);
        }

        // Operation methods

        public IAlgebraElmt Plus(IAlgebraElmt oprd)
        {
            return new Real(Val + ((Real) oprd).Val);
        }

        public IAlgebraElmt Neg()
        {
            return new Real(-Val);
        }

        public IAlgebraElmt Minus(IAlgebraElmt oprd)
        {
            return ((Real) ((Real) oprd).Neg()).Plus(this);
        }

        public IAlgebraElmt Recp()
        {
            return new Real(1.0/Val);
        }

        public IAlgebraElmt DivBy(IAlgebraElmt oprd)
        {
            return ((Real)((Real)oprd).Recp()).Times(this);
        }

        public IAlgebraElmt Times(IAlgebraElmt oprd)
        {
            return new Real(Val * ((Real)oprd).Val);
        }
    }

}
