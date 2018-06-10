using System;
using Calc.AlgebraSystems;
using Calc.AlgebraSystems.Relations.Instances;
using Calc.AlgebraSystems.Structures.Ring;

namespace Calc.Numerical.DataTypes.Naive
{
    public sealed class NInteger : ICommutativeRingElement, IEquivalent, IOrderable
    {
        public static NInteger O = new NInteger {Val = 0};
        public static NInteger I = new NInteger {Val = 1};

        private Int64 Val { get; set; }

        #region Operators

        public static NInteger operator +(NInteger left, NInteger right)
        {
            return (NInteger) left.Plus(right);
        }

        public static NInteger operator -(NInteger left, NInteger right)
        {
            return (NInteger) ((NInteger) right.Neg()).Plus(left);
        }

        public static NInteger operator *(NInteger left, NInteger right)
        {
            return (NInteger) left.Times(right);
        }

        public static bool operator ==(NInteger left, NInteger right)
        {
            // ReSharper disable once PossibleNullReferenceException
            return left.EquivalentTo(right);
        }

        public static bool operator !=(NInteger left, NInteger right)
        {
            return !(left == right);
        }

        public static bool operator <(NInteger left, NInteger right)
        {
            return left.LessThan(right);
        }

        public static bool operator >(NInteger left, NInteger right)
        {
            return right.LessThan(left);
        }

        public static bool operator <=(NInteger left, NInteger right)
        {
            return left < right || left == right;
        }

        public static bool operator >=(NInteger left, NInteger right)
        {
            return left > right || left == right;
        }

        #endregion

        #region Operrational Methods

        public IAlgebraicElement Plus(IAlgebraicElement oprd)
        {
            return new NInteger(Val + ((NInteger) oprd).Val);
        }

        public IAlgebraicElement Neg()
        {
            return new NInteger(-Val);
        }

        public IAlgebraicElement Times(IAlgebraicElement oprd)
        {
            return new NInteger(Val*((NInteger) oprd).Val);
        }

        #endregion

        #region Relations

        public bool EquivalentTo(IAlgebraicElement oprd)
        {
            return Val == ((NInteger) oprd).Val;
        }

        public bool LessThan(IAlgebraicElement oprd)
        {
            return Val < ((NInteger)oprd).Val;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is NInteger && Val == ((NInteger) obj).Val;
        }

        public override int GetHashCode()
        {
            return Val.GetHashCode();
        }

        #endregion

        #region Transpormations

        public NInteger(Int64 val)
        {
            Val = val;
        }

        public NInteger() : this(0)
        {

        }

        public static implicit operator NInteger(Int64 val)
        {
            return new NInteger(val);
        }

        public static implicit operator Int64(NInteger ni)
        {
            return ni.Val;
        }

        public static implicit operator NReal(NInteger ni)
        {
            return new NReal(ni.Val);
        }

        public override string ToString()
        {
            return Val.ToString(System.Globalization.CultureInfo.InvariantCulture);
        }

        #endregion

    }
}
