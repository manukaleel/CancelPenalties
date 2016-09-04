using System;
using System.Runtime.Remoting.Channels;

namespace CancelPenalties
{
    public class FullStayBuilder : ICancellationBuilder
    {
        private CancelData _cancelData;

        public FullStayBuilder(CancelData cancelData)
        {
            _cancelData = cancelData;
        }

        public string BuildFirstSection()
        {
            return "Credit card required to secure your booking";
        }

        public string BuildMiddleSection()
        {
            return string.Format("You can cancel until {0} before the date of arrival", _cancelData.DeadlineDays);
        }

        public string BuildEndSection()
        {
            return "If you cancel later the full stay amount will be charged";
        }
    }
}