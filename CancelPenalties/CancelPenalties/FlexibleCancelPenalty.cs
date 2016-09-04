﻿using System;

namespace CancelPenalties
{
    public class FlexibleCancelPenalty : ICancellationBuilder
    {
        private CancelData _cancelData;

        public FlexibleCancelPenalty(CancelData cancelData)
        {
            _cancelData = cancelData;
        }

        public string BuildFirstSection()
        {
            return "Credit card required to secure your booking";
        }

        public string BuildMiddleSection()
        {
            return string.Format("You can cancel free until {0} days", _cancelData.DeadlineDays);
        }

        public string BuildEndSection()
        {
            return string.Format("If cancelled later {0} will be charged", _cancelData.Amount);
        }
    }
}