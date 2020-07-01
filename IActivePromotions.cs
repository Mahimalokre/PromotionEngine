using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Contracts
{
    /// <summary>
    /// The Promotion Type.
    /// </summary>
    public interface IActivePromotions
    {
        /// <summary>
        /// Gets a type active promotion price.
        /// </summary>
        /// <param name="quantityA">The quantity a.</param>
        /// <returns></returns>
        public int GetATypeActivePromotionPrice(int quantityA);

        /// <summary>
        /// Gets the b type active promotion price.
        /// </summary>
        /// <param name="quantityB">The quantity b.</param>
        /// <returns></returns>
        public int GetBTypeActivePromotionPrice(int quantityB);

        /// <summary>
        /// Gets the c and d type active promotion price.
        /// </summary>
        /// <param name="quantityC">The quantity c.</param>
        /// <param name="quntityD">The quntity d.</param>
        /// <returns></returns>
        public int GetCAndDTypeActivePromotionPrice(int quantityC, int quntityD);
    }
}
