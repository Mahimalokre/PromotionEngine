using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Contracts
{
    /// <summary>
    /// The cart class.
    /// </summary>
    /// <seealso cref="PromotionEngine.Contracts.ICart" />
    public class Cart : ICart
    {
        /// <summary>
        /// The active promotions
        /// </summary>
        private IActivePromotions activePromotions;

        /// <summary>
        /// Gets or sets the active promotions.
        /// </summary>
        /// <value>
        /// The active promotions.
        /// </value>
        public IActivePromotions ActivePromotions
        {
            get
            {
                if (this.activePromotions == null)
                {
                    this.activePromotions = new ActivePromotions();
                }

                return this.activePromotions;
            }

            set
            {
                this.activePromotions = value;
            }
        }

        /// <summary>
        /// Gets the cart calculated.
        /// </summary>
        /// <param name="sku">The sku.</param>
        /// <returns></returns>
        public int GetCartCalculated(Sku sku)
        {            
            var aData = ActivePromotions.GetATypeActivePromotionPrice(sku.A);
            var bData = ActivePromotions.GetBTypeActivePromotionPrice(sku.B);
            var cdData = ActivePromotions.GetCAndDTypeActivePromotionPrice(sku.C, sku.D);
            return (aData + bData + cdData);
        }                   
    }
}
