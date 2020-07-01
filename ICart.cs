using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Contracts
{
    /// <summary>
    /// The cart interface.
    /// </summary>
    public interface ICart
    {
        int GetCartCalculated(Sku sku);
    }
}
