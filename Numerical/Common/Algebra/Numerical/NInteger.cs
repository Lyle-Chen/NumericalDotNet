using System;
using Numerical.Common.Algebra.Abstract;
using Numerical.Common.Algebra.Interface;

namespace Numerical.Common.Algebra.Numerical
{
    public sealed class NInteger : ACommutativeRingElmt
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
            return (NInteger) right.Neg().Plus(left);
        }

        public static NInteger operator *(NInteger left, NInteger right)
        {
            return (NInteger) left.Times(right);
        }

        #endregion

        #region Operrational Methods

        public override ICommutativeRingElmt Plus(ICommutativeRingElmt oprd)
        {
            return new NInteger(Val + ((NInteger) oprd).Val);
        }

        public override ICommutativeRingElmt Neg()
        {
            return new NInteger(-Val);
        }

        public override ICommutativeRingElmt Times(ICommutativeRingElmt oprd)
        {
            return new NInteger(Val*((NInteger) oprd).Val);
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

        public static implicit operator Int64(NInteger i)
        {
            return i.Val;
        }

        public static implicit operator NReal(NInteger i)
        {
            return new NReal(i.Val);
        }

        public override string ToString()
        {
            return Val.ToString(System.Globalization.CultureInfo.InvariantCulture);
        }

        #endregion
    }
}
