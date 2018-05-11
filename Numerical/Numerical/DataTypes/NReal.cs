using System;
using Calc.Common.Algebra.Relation.Equivalent;
using Calc.Common.Algebra.Relation.Ordered;
using Calc.Common.Algebra.Structure;
using Calc.Common.Algebra.Structure.Field;

namespace Calc.Numerical.DataTypes
{
    public sealed class NReal : IFieldElement, IEqualable, IOrderable
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
            return (NReal) ((NReal) right.Neg()).Plus(left);
        }

        public static NReal operator *(NReal left, NReal right)
        {
            return (NReal) left.Times(right);
        }

        public static NReal operator /(NReal left, NReal right)
        {
            return (NReal) ((NReal) right.Recp()).Times(left);
        }

        public static bool operator ==(NReal left, NReal right)
        {
            // ReSharper disable once PossibleNullReferenceException
            return left.EquivalentTo(right);
        }

        public static bool operator !=(NReal left, NReal right)
        {
            return !(left == right);
        }

        public static bool operator <(NReal left, NReal right)
        {
            return left.LessThan(right);
        }

        public static bool operator >(NReal left, NReal right)
        {
            return right.LessThan(left);
        }

        public static bool operator <=(NReal left, NReal right)
        {
            return left < right || left == right;
        }

        public static bool operator >=(NReal left, NReal right)
        {
            return left > right || left == right;
        }

        #endregion

        #region Operational methods

        public IAlgebraicElement Plus(IAlgebraicElement oprd)
        {
            return new NReal(Val + ((NReal) oprd).Val);
        }

        public IAlgebraicElement Neg()
        {
            return new NReal(-Val);
        }

        public IAlgebraicElement Times(IAlgebraicElement oprd)
        {
            return new NReal(Val*((NReal) oprd).Val);
        }

        public IAlgebraicElement Recp()
        {
            return new NReal(1.0/Val);
        }

        #endregion

        #region Relations

        public bool LessThan(IAlgebraicElement oprd)
        {
            return Val < ((NReal) oprd).Val;
        }

        public bool EquivalentTo(IAlgebraicElement oprd)
        {
            return Math.Abs(Val - ((NReal)oprd).Val) < Double.Epsilon;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is NReal && Math.Abs(Val - ((NReal)obj).Val) < Double.Epsilon;
        }

        public override int GetHashCode()
        {
            return Val.GetHashCode();
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
