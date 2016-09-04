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
            var cancelData = new CancelData {AdvancePurchase = true, DeadlineDays = 0};

            var text = cancellationPolicyProvider.Build(new AdvancePurchaseBuilder(), cancelData);


            Console.Write(text);

            Console.ReadLine();
        }
    }

    

    public class CancellationPolicyProvider
    {
        public string Build(ICancellationBuilder cancellationBuilder, CancelData cancelData)
        {
            string cancellationText;

            cancellationText = cancellationBuilder.BuildFirstSection(cancelData);
            cancellationText += cancellationBuilder.BuildFirstSection(cancelData);
            cancellationText += cancellationBuilder.BuildEndSection(cancelData);

            return cancellationText;
        }
    }
}
