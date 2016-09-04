using System;
using System.Collections.Generic;

namespace CancelPenalties
{
    public class AdvancePurchaseBuilder: ICancellationBuilder
    {
        private List<CancelData> _cancelData;

        public AdvancePurchaseBuilder(List<CancelData> cancelData)
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