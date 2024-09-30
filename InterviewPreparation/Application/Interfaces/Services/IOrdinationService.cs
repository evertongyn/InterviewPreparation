namespace InterviewPreparation.Application.Interfaces.Services
{
    public interface IOrdinationService
    {
        IEnumerable<int> OrderSimply(IEnumerable<int> enumerableToOrder);
    }
}
