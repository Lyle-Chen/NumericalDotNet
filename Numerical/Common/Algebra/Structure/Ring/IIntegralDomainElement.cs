namespace Calc.Common.Algebra.Structure.Ring
{
    /// <summary>
    /// Integral Domain: Communative Ring who's opt Times complies to cancellation law (if a ≠ 0, then ab = ac implies b = c).
    /// </summary>
    public interface IIntegralDomainElement : ICommutativeRingElement
    {
        IIntegralDomainElement Plus(IIntegralDomainElement oprd);

        new IIntegralDomainElement Neg();

        IIntegralDomainElement Times(IIntegralDomainElement oprd);
    }
}
