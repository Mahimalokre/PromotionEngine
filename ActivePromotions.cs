using PromotionEngine.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Contracts
{
    /// <summary>
    /// The Promotion Type.
    /// </summary>
    /// <seealso cref="PromotionEngine.Contracts.IActivePromotions" />
    public class ActivePromotions : IActivePromotions
    {
        /// <summary>
        /// Gets a type active promotion.
        /// </summary>
        /// <param name="quantityA">a.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public int GetATypeActivePromotionPrice(int quantityA)
        {
            int finalResult = 0;
            var multiple = quantityA / (int)RuleQuantity.A;
            if(multiple > 0)
            {
                finalResult = finalResult + (multiple * (int)RuleQuantityPrice.A);
            }

            var remainder = quantityA % (int)RuleQuantity.A;
            finalResult = finalResult + (remainder * (int)IndividualPrices.A);
            return finalResult;
        }

        /// <summary>
        /// Gets the b type active promotion.
        /// </summary>
        /// <param name="quantityB">The b.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public int GetBTypeActivePromotionPrice(int quantityB)
        {
            int finalResult = 0;
            var multiple = quantityB / (int)RuleQuantity.B;
            if (multiple > 0)
            {
                finalResult = finalResult + (multiple * (int)RuleQuantityPrice.B);
            }

            var remainder = quantityB % (int)RuleQuantity.B;
            finalResult = finalResult + (remainder * (int)IndividualPrices.B);
            return finalResult;
        }

        /// <summary>
        /// Gets the c and d type active promotion.
        /// </summary>
        /// <param name="quantityC">The c.</param>
        /// <param name="quantityD">The d.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public int GetCAndDTypeActivePromotionPrice(int quantityC, int quantityD)
        {
            if (quantityC == quantityD)
            {
                return quantityC * (int)RuleQuantityPrice.CD;
            }
            else if (quantityC > quantityD)
            {
                var diff = quantityC - quantityD;
                return ((diff * (int)IndividualPrices.C) + (quantityD * (int)RuleQuantityPrice.CD));
            }
            else
            {
                var diff = quantityD - quantityC;
                return ((diff * (int)IndividualPrices.D) + (quantityC * (int)RuleQuantityPrice.CD));
            }            
        }
    }
}
