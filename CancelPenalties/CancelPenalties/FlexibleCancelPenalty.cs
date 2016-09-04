using System;
using System.Collections.Generic;
using System.Linq;

namespace CancelPenalties
{
    public class FlexibleCancelPenalty : ICancellationBuilder
    {
        private List<CancelData> _cancelData;

        public FlexibleCancelPenalty(List<CancelData> cancelData)
        {
            _cancelData = cancelData;
        }

        public string BuildFirstSection()
        {
            return "Credit card required to secure your booking";
        }

        public string BuildMiddleSection()
        {
            return string.Format("You can cancel free until {0} days", _cancelData.First().DeadlineDays);
        }

        public string BuildEndSection()
        {
            return string.Format("If cancelled later {0} will be charged", _cancelData.First().Amount);
        }
    }
}