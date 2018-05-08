namespace Numerical.Common.Algebra.Interface
{
    /// <summary>
    /// Algebra: Set with binary opts.
    /// </summary>
    public interface IAlgebraicElmt
    {

    }

    //////////////////////////////////////// Interfaces of group-like algebras ////////////////////////////////////////

    /// <summary>
    /// Magma: Algebra with a closed Opt.
    /// </summary>
    public interface IMagmaElmt : IAlgebraicElmt
    {
        IMagmaElmt Opt(IMagmaElmt oprd);
    }

    /// <summary>
    /// Semigroup: Magma who's Opt is also associative.
    /// </summary>
    public interface ISemigroupElmt : IMagmaElmt
    {
        ISemigroupElmt Opt(ISemigroupElmt oprd);
    }

    /// <summary>
    /// Monoid: Semigroup with an Identity (both left and right).
    /// </summary>
    public interface IMonoidElmt : ISemigroupElmt
    {
        IMonoidElmt Opt(IMonoidElmt oprd);
    }

    /// <summary>
    /// Group: Monoid that every element has its invertibility.
    /// </summary>
    public interface IGroupElmt : IMonoidElmt
    {
        IGroupElmt Opt(IGroupElmt oprd);

        IGroupElmt Inv();
    }

    /// <summary>
    /// Abelian Group: Group who's Opt is also commutative.
    /// </summary>
    public interface IAbelianGroupElmt : IGroupElmt
    {
        IAbelianGroupElmt Opt(IAbelianGroupElmt oprd);

        new IAbelianGroupElmt Inv();
    }

    //////////////////////////////////////// Interfaces of rings and fields ////////////////////////////////////////

    /// <summary>
    /// Ring: Algebra which constitutes an Abelian Group with its opt Plus (so that Neg() exists), and a Monoid with its opt Times, where Times distributes over Plus.
    /// </summary>
    public interface IRingElmt : IAlgebraicElmt
    {
        IRingElmt Plus(IRingElmt oprd);

        IRingElmt Neg();

        IRingElmt Times(IRingElmt oprd);
    }

    /// <summary>
    /// Communative Ring: Ring who's opt Times is commutative.
    /// </summary>
    public interface ICommutativeRingElmt : IRingElmt
    {
        ICommutativeRingElmt Plus(ICommutativeRingElmt oprd);

        new ICommutativeRingElmt Neg();

        ICommutativeRingElmt Times(ICommutativeRingElmt oprd);
    }

    /// <summary>
    /// Integral Domain: Communative Ring who's opt Times complies to cancellation law (if a ≠ 0, then ab = ac implies b = c).
    /// </summary>
    public interface IIntegralDomainElmt : ICommutativeRingElmt
    {
        IIntegralDomainElmt Plus(IIntegralDomainElmt oprd);

        new IIntegralDomainElmt Neg();

        IIntegralDomainElmt Times(IIntegralDomainElmt oprd);
    }

    /// <summary>
    /// Field: Commutative Ring which also constitutes an Abelian Group with its opt Times (so that Recp() exists).
    /// </summary>
    public interface IFieldElmt : ICommutativeRingElmt
    {
        IFieldElmt Plus(IFieldElmt oprd);

        new IFieldElmt Neg();

        IFieldElmt Times(IFieldElmt oprd);

        IFieldElmt Recp();
    }
}
