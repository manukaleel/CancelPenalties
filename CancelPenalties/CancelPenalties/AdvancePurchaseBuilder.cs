using System;

namespace CancelPenalties
{
    public class AdvancePurchaseBuilder: ICancellationBuilder
    {
        private CancelData _cancelData;

        public AdvancePurchaseBuilder(CancelData cancelData)
        {
            _cancelData = cancelData;
        }

        public string BuildFirstSection()
        {
            return "This is an Advanced purchase";
        }

        public string BuildMiddleSection()
        {
            return "";
        }

        public string BuildEndSection()
        {
            return "";
        }
    }
}