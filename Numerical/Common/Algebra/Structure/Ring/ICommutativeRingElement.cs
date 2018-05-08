namespace Calc.Common.Algebra.Structure.Ring
{
    /// <summary>
    /// Communative Ring: Ring who's opt Times is commutative.
    /// </summary>
    public interface ICommutativeRingElement : IRingElement
    {
        ICommutativeRingElement Plus(ICommutativeRingElement oprd);

        new ICommutativeRingElement Neg();

        ICommutativeRingElement Times(ICommutativeRingElement oprd);
    }
}
