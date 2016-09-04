using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;

namespace CancelPenalties
{
    public class CancellationPolicyProvider
    {
        public string Build(ICancellationBuilder cancellationBuilder, List<CancelData> cancelData)
        {
            string cancellationText = null;

            if (cancelData.Count == 1)
            {
                cancellationText = cancellationBuilder.BuildFirstSection();
                cancellationText += cancellationBuilder.BuildFirstSection();
                cancellationText += cancellationBuilder.BuildEndSection();

                return cancellationText;
            }
            else if (cancelData.Count > 1 && cancellationBuilder is FlexibleCancelPenalty)
            {
                //Modify Cancel penalty and pass it to the first section
                //foreach cancel penalty
                //Build the middle section 
                //Build the tiered section 
                //Build the last section
            }

            return cancellationText;
        }
    }
}