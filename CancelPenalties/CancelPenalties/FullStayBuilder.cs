using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;

namespace CancelPenalties
{
    public class FullStayBuilder : CommonCancellation, ICancellationBuilder
    {
        private List<CancelData> _cancelData;

        public FullStayBuilder(List<CancelData> cancelData)
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
            return "If you cancel later the full stay amount will be charged";
        }
    }
}