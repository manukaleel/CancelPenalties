using System;
using System.Collections.Generic;
using System.Linq;

namespace CancelPenalties
{
    public class FlexibleCancelPenalty : CommonCancellation, ICancellationBuilder
    {
        private List<CancelData> _cancelData;

        public FlexibleCancelPenalty(List<CancelData> cancelData)
        {
            _cancelData = cancelData;
        }

        public string BuildFirstSection()
        {
            return base.StartingText;
        }

        public string BuildMiddleSection()
        {
            return string.Format(base.DeadlineText, _cancelData.First().DeadlineDays);
        }

        public string BuildEndSection()
        {
            return string.Format("If cancelled later {0} will be charged", _cancelData.First().Amount);
        }
    }
}