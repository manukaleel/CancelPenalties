using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CancelPenalties
{
    class Program
    {
        static void Main(string[] args)
        {
            var cancellationPolicyProvider = new CancellationPolicyProvider();

            var cancelDataList = new List<CancelData>
            {
                new CancelData {AdvancePurchase = true, DeadlineDays = 2, Amount = 10},
                new CancelData {AdvancePurchase = true, DeadlineDays = 5, Amount = 20}
            };

            var text = cancellationPolicyProvider.Build(new AdvancePurchaseBuilder(cancelDataList), cancelDataList);
            Console.Write(text + "\n\n");

            text = cancellationPolicyProvider.Build(new FullStayBuilder(cancelDataList), cancelDataList);
            Console.Write(text + "\n\n");

            text = cancellationPolicyProvider.Build(new FlexibleCancelPenalty(cancelDataList), cancelDataList);
            Console.Write(text + "\n\n");

            Console.ReadLine();
        }
    }
}
