namespace CancelPenalties
{
    public interface ICancellationBuilder
    {
        string BuildFirstSection(CancelData cancelData);
        string BuildMiddleSection(CancelData cancelData);
        string BuildEndSection(CancelData cancelData);
    }
}