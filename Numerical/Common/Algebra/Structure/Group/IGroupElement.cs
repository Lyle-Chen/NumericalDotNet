﻿namespace Calc.Common.Algebra.Structure.Group
{
    /// <summary>
    /// Group: Monoid that every element has its invertibility.
    /// </summary>
    public interface IGroupElement : IMonoidElement
    {
        IGroupElement Opt(IGroupElement oprd);

        IGroupElement Inv();
    }
}