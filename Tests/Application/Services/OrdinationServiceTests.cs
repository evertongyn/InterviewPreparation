using InterviewPreparation.Application.Services;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Xunit;

namespace InterviewPreparation.Tests.Application.Services
{
    public class OrdinationServiceTests
    {
        [Fact]
        public void OrderSimplyBasicScenario()
        {
            var service = new OrdinationService();
            var itemsToSort = new List<int> { 2, 3, 1 };
            var sortedList = service.OrderSimply(itemsToSort).ToList();

            Assert.NotNull(sortedList);
            Assert.Equal(itemsToSort.Count, sortedList.Count);
            Assert.Equal(1, sortedList[0]);
            Assert.Equal(2, sortedList[1]);
            Assert.Equal(3, sortedList[2]);
        }
    }
}
