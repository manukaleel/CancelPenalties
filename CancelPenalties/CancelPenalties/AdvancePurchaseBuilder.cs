using System;

namespace CancelPenalties
{
    public class AdvancePurchaseBuilder: ICancellationBuilder
    {
        public string BuildFirstSection(CancelData cancelData)
        {
            return "This is an Advanced purchase";
        }

        public string BuildMiddleSection(CancelData cancelData)
        {
            return "";
        }

        public string BuildEndSection(CancelData cancelData)
        {
            return "";
        }
    }
}