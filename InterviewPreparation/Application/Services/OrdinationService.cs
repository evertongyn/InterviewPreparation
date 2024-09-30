using InterviewPreparation.Application.Interfaces.Services;

namespace InterviewPreparation.Application.Services
{
    public class OrdinationService : IOrdinationService
    {
        public IEnumerable<int> OrderSimply(IEnumerable<int> enumerableToOrder)
        {
            var orderedArray = new List<int>();
            for (int i = 0; i < enumerableToOrder.Count(); i++)
            {
                var currentElementToInsert = enumerableToOrder.ElementAt(i);
                if (orderedArray.Count == 0)
                {
                    orderedArray.Add(currentElementToInsert);
                }
                else
                {
                    for (int j = 0; j < orderedArray.Count; j++)
                    {
                        var currentComparableElement = orderedArray.ElementAt(j);
                        if (currentComparableElement > currentElementToInsert)
                        {
                            orderedArray.Insert(j, currentElementToInsert);
                            break;
                        }
                        else if (orderedArray.Count == j + 1)
                        {
                            orderedArray.Insert(j + 1, currentElementToInsert);
                            break;
                        }
                    }
                }
            }

            return orderedArray;
        }
    }
}
