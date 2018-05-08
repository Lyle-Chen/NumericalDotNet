using System;
using Calc.Common.Algebra.Structure.Field;

namespace Calc.Numerical.DataTypes
{
    public sealed class NReal : AFieldElement
    {
        public static int Precision = 6;

        public static NReal O = new NReal {Val = 0.0};
        public static NReal I = new NReal {Val = 1.0};

        private Double Val { get; set; }

        #region Operators

        public static NReal operator +(NReal left, NReal right)
        {
            return (NReal) left.Plus(right);
        }

        public static NReal operator -(NReal left, NReal right)
        {
            return (NReal) right.Neg().Plus(left);
        }

        public static NReal operator *(NReal left, NReal right)
        {
            return (NReal) left.Times(right);
        }

        public static NReal operator /(NReal left, NReal right)
        {
            return (NReal) right.Recp().Times(left);
        }

        #endregion

        #region Operational methods

        public override IFieldElement Plus(IFieldElement oprd)
        {
            return new NReal(Val + ((NReal) oprd).Val);
        }

        public override IFieldElement Neg()
        {
            return new NReal(-Val);
        }

        public override IFieldElement Times(IFieldElement oprd)
        {
            return new NReal(Val*((NReal) oprd).Val);
        }

        public override IFieldElement Recp()
        {
            return new NReal(1.0/Val);
        }

        #endregion

        #region Transformations

        public NReal(double val)
        {
            Val = val;
        }

        public NReal() : this(0.0)
        {

        }

        public static implicit operator NReal(Double val)
        {
            return new NReal(val);
        }

        public static implicit operator Double(NReal r)
        {
            return r.Val;
        }

        public override string ToString()
        {
            return Val.ToString(string.Format("f{0}", Precision));
        }

        #endregion
    }
}
