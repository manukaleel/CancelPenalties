namespace CancelPenalties
{
    public interface ICancellationBuilder
    {
        string BuildFirstSection();
        string BuildMiddleSection();
        string BuildEndSection();
    }
}