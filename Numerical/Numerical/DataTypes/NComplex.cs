using System;
using Calc.Common.Algebra.Relation.Equivalent;
using Calc.Common.Algebra.Structure;
using Calc.Common.Algebra.Structure.Field;

namespace Calc.Numerical.DataTypes
{
    public sealed class NComplex : IFieldElement, IEqualable
    {
        public static int Precision = 6;

        public static NComplex O = NReal.O;
        public static NComplex I = NReal.I;
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
            return (NComplex) ((NComplex) right.Neg()).Plus(left);
        }

        public static NComplex operator *(NComplex left, NComplex right)
        {
            return (NComplex)left.Times(right);
        }

        public static NComplex operator /(NComplex left, NComplex right)
        {
            return (NComplex) ((NComplex) right.Recp()).Times(left);
        }

        public static NComplex operator ~(NComplex oprd)
        {
            return new NComplex(oprd.Re, -oprd.Im);
        }

        public static bool operator ==(NComplex left, NComplex right)
        {
            // ReSharper disable once PossibleNullReferenceException
            return left.EquivalentTo(right);
        }

        public static bool operator !=(NComplex left, NComplex right)
        {
            return !(left == right);
        }

        #endregion

        #region Operational methods

        public IAlgebraicElement Plus(IAlgebraicElement oprd)
        {
            return new NComplex(Re + ((NComplex) oprd).Re, Im + ((NComplex) oprd).Im);
        }

        public IAlgebraicElement Neg()
        {
            return new NComplex(-Re, -Im);
        }

        public IAlgebraicElement Times(IAlgebraicElement oprd)
        {
            var r1 = Re;
            var r2 = ((NComplex) oprd).Re;
            var i1 = Im;
            var i2 = ((NComplex) oprd).Im;

            return new NComplex(r1*r2 - i1*i2, r1*i2 + r2*i1);
        }

        public IAlgebraicElement Recp()
        {
            var s = Re*Re + Im*Im;
            return new NComplex(Re/s, -Im/s);
        }

        #endregion

        #region Relations

        public bool EquivalentTo(IAlgebraicElement oprd)
        {
            return Re == ((NComplex) oprd).Re && Im == ((NComplex) oprd).Im;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is NComplex && Re == ((NComplex) obj).Re && Im == ((NComplex) obj).Im;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Re != null ? Re.GetHashCode() : 0)*397) ^ (Im != null ? Im.GetHashCode() : 0);
            }
        }

        #endregion

        #region Transformations

        public NComplex(NReal re, NReal im)
        {
            Re = re;
            Im = im;
        }

        public NComplex(NReal re) : this(re, NReal.O)
        {

        }

        public NComplex() : this(NReal.O)
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
