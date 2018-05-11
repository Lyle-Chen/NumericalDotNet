﻿using Calc.Common.AlgebraSystems.Structures;

namespace Calc.Common.AlgebraSystems.Relations
{
    public interface IRelational : IAlgebraicElement
    {
        bool R(IAlgebraicElement oprd);
    }
}