using System;
using Calc.Common.Algebra.Structure.Field;

namespace Calc.Numerical.DataTypes
{
    public sealed class NComplex : AFieldElement
    {
        public static int Precision = 6;

        public static NComplex O = new NComplex(0.0);
        public static NComplex I = new NComplex(1.0);
        public static NComplex J = new NComplex(0.0, 1.0);

        public NReal Re { get; set; }
        public NReal Im { get; set; }

        #region Operators

        public static NComplex operator +(NComplex left, NComplex right)
        {
            return (NComplex) left.Plus(right);
        }

        public static NComplex operator -(NComplex left, NComplex right)
        {
            return (NComplex) right.Neg().Plus(left);
        }

        public static NComplex operator *(NComplex left, NComplex right)
        {
            return (NComplex)left.Times(right);
        }

        public static NComplex operator /(NComplex left, NComplex right)
        {
            return (NComplex)right.Recp().Times(left);
        }

        public static NComplex operator ~(NComplex oprd)
        {
            return new NComplex(oprd.Re, -oprd.Im);
        }

        #endregion

        #region Operational methods

        public override IFieldElement Plus(IFieldElement oprd)
        {
            return new NComplex(Re + ((NComplex) oprd).Re, Im + ((NComplex) oprd).Im);
        }

        public override IFieldElement Neg()
        {
            return new NComplex(-Re, -Im);
        }

        public override IFieldElement Times(IFieldElement oprd)
        {
            var r1 = Re;
            var r2 = ((NComplex) oprd).Re;
            var i1 = Im;
            var i2 = ((NComplex) oprd).Im;

            return new NComplex(r1*r2 - i1*i2, r1*i2 + r2*i1);
        }

        public override IFieldElement Recp()
        {
            var s = Re*Re + Im*Im;
            return new NComplex(Re/s, -Im/s);
        }

        #endregion

        #region Transformations

        public NComplex(NReal re, NReal im)
        {
            Re = re;
            Im = im;
        }

        public NComplex(NReal re) : this(re, 0.0)
        {

        }

        public NComplex() : this(0.0)
        {

        }

        public static implicit operator NComplex(NReal real)
        {
            return new NComplex(real);
        }

        public static implicit operator NComplex(Double real)
        {
            return new NComplex(real);
        }

        public override string ToString()
        {
            var p = NReal.Precision;

            NReal.Precision = Precision;
            var result = string.Format("({0} {1}i)", Re, Im);
            NReal.Precision = p;

            return result;
        }

        #endregion
    }
}
