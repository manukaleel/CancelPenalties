namespace CancelPenalties
{
    public class CancellationPolicyProvider
    {
        public string Build(ICancellationBuilder cancellationBuilder, CancelData cancelData)
        {
            string cancellationText;

            cancellationText = cancellationBuilder.BuildFirstSection();
            cancellationText += cancellationBuilder.BuildFirstSection();
            cancellationText += cancellationBuilder.BuildEndSection();

            return cancellationText;
        }
    }
}