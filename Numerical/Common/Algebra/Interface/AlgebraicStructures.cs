using System;

namespace Numerical.Common.Algebra.Interface
{
    /// <summary>
    /// Algebra: Set with binary opts.
    /// </summary>
    public interface IAlgebraElmt
    {

    }

    //////////////////////////////////////// Attributes for ALGEBRAS ////////////////////////////////////////

    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class)]
    public class AlgebraAttr : Attribute
    {
        public AlgebraFlag Flag { get; set; }

        public AlgebraAttr(AlgebraFlag flag)
        {
            Flag = flag;
        }
    }

    [Flags]
    public enum AlgebraFlag
    {
        LeftZero,
        RightZero,
        Zero = LeftZero | RightZero,

        LeftIdentity, // Exists el ∈ G, for any a ∈ G, (el @ a) = a.
        RightIdentity, // Exists er ∈ G, for any a ∈ G, (a @ er) = a.
        Identity = LeftIdentity | RightIdentity,

        LeftInvertibility, // For any a ∈ G, exists bl ∈ G, (bl @ a) = e.
        RightInvertibility, // For any a ∈ G, exists br ∈ G, (a @ br) = e.
        Invertibility = LeftInvertibility | RightInvertibility
    }

    //////////////////////////////////////// Attributes for OPERATORS ////////////////////////////////////////

    [AttributeUsage(AttributeTargets.Method)]
    public class OptAttr : Attribute
    {
        public OptFlag Flag { get; set; }

        public OptAttr(OptFlag flag)
        {
            Flag = flag;
        }
    }

    [Flags]
    public enum OptFlag
    {
        Closed, // For any a, b ∈ G, (a @ b) ∈ G.
        Associative, // For any a, b, c ∈ G, (a @ b @ c) =def= ((a @ b) @ c) = (a @ (b @ c)).
        Commutative, // For any a, b ∈ G, (a @ b) = (b @ a).
        LeftDistributive, // For any a, b, c ∈ G, a @ (b # c) = (a @ b) # (a @ c), where # is an opt rather than @.
        RightDistributive, // For any a, b, c ∈ G, (b # c) @ a = (b @ a) # (c @ a), where # is an opt rather than @.
        Distributive = LeftDistributive | RightDistributive,
    }

    //////////////////////////////////////// Interfaces of group-like algebras ////////////////////////////////////////

    /// <summary>
    /// Magma: Algebra with a closed Opt.
    /// </summary>
    public interface IMagmaElmt : IAlgebraElmt
    {
        [OptAttr(OptFlag.Closed)]
        IAlgebraElmt Opt(IAlgebraElmt algebra);
    }

    /// <summary>
    /// Semigroup: Magma who's Opt is also associative.
    /// </summary>
    public interface ISemigroupElmt : IMagmaElmt
    {
        [OptAttr(OptFlag.Closed | OptFlag.Associative)]
        new IAlgebraElmt Opt(IAlgebraElmt algebra);
    }

    /// <summary>
    /// Monoid: Semigroup with an Identity (both left and right).
    /// </summary>
    [AlgebraAttr(AlgebraFlag.Identity)]
    public interface IMonoidElmt : ISemigroupElmt
    {

    }

    /// <summary>
    /// Group: Monoid that every element has its invertibility.
    /// </summary>
    [AlgebraAttr(AlgebraFlag.Invertibility)]
    public interface IGroupElmt : IMonoidElmt
    {
        [OptAttr(OptFlag.Closed)]
        IAlgebraElmt Inv();
    }

    /// <summary>
    /// Abelian Group: Group who's Opt is also commutative.
    /// </summary>
    public interface IAbelianGroupElmt : IGroupElmt
    {
        [OptAttr(OptFlag.Closed | OptFlag.Associative | OptFlag.Commutative)]
        new IAlgebraElmt Opt(IAlgebraElmt algebra);
    }

    //////////////////////////////////////// Interfaces of rings and fields ////////////////////////////////////////

    /// <summary>
    /// Ring: Algebra which constitutes an Abelian Group with its opt Plus (so that Neg() exists), and a Monoid with its opt Times, where Times distributes over Plus.
    /// </summary>
    [AlgebraAttr(AlgebraFlag.Identity | AlgebraFlag.Zero)]
    public interface IRingElmt : IAlgebraElmt
    {
        [OptAttr(OptFlag.Closed | OptFlag.Associative | OptFlag.Commutative)]
        IAlgebraElmt Plus(IAlgebraElmt oprd);

        [OptAttr(OptFlag.Closed)]
        IAlgebraElmt Neg();

        [OptAttr(OptFlag.Closed | OptFlag.Associative)]
        IAlgebraElmt Times(IAlgebraElmt oprd);
    }

    /// <summary>
    /// Communative Ring: Ring who's opt Times is commutative.
    /// </summary>
    public interface ICommutativeRingElmt : IRingElmt
    {
        [OptAttr(OptFlag.Closed | OptFlag.Associative | OptFlag.Commutative)]
        new IAlgebraElmt Times(IAlgebraElmt oprd);
    }

    /// <summary>
    /// Integral Domain: Communative Ring who's opt Times complies to cancellation law (if a ≠ 0, then ab = ac implies b = c).
    /// </summary>
    public interface IIntegralDomainElmt : ICommutativeRingElmt
    {

    }

    /// <summary>
    /// Field: Commutative Ring which also constitutes an Abelian Group with its opt Times (so that Recp() exists).
    /// </summary>
    public interface IFieldElmt : ICommutativeRingElmt
    {
        [OptAttr(OptFlag.Closed)]
        IAlgebraElmt Recp();
    }


}
