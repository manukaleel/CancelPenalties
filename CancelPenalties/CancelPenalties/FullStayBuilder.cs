using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;

namespace CancelPenalties
{
    public class FullStayBuilder : ICancellationBuilder
    {
        private List<CancelData> _cancelData;

        public FullStayBuilder(List<CancelData> cancelData)
        {
            _cancelData = cancelData;
        }

        public string BuildFirstSection()
        {
            return "Credit card required to secure your booking";
        }

        public string BuildMiddleSection()
        {
            return string.Format("You can cancel until {0} before the date of arrival", _cancelData.First().DeadlineDays);
        }

        public string BuildEndSection()
        {
            return "If you cancel later the full stay amount will be charged";
        }
    }
}