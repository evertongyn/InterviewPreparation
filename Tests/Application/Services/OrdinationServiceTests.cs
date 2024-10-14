using InterviewPreparation.Application.Services;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using System.Text;
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

            var teste = new string[3];
            teste[0] = "flower";
            teste[1] = "flow";
            teste[2] = "flight";
            var longestPrefix = LongestCommonPrefix(teste);
            Assert.NotEqual("", longestPrefix);
        }

        public string LongestCommonPrefix(string[] strs)
        {
            var longestPrefix = new StringBuilder();
            for (int i = 0; i < strs[0].Length; i++)
            {
                var anchorLetter = strs[0][i];
                for (int j = 1; j < strs.Count(); j++)
                {
                    var currentString = strs[j];
                    if (i >= currentString.Length)
                    {
                        return longestPrefix.ToString();
                    }
                    else
                    {
                        var currentLetter = currentString[i];
                        if (!anchorLetter.Equals(currentLetter))
                        {
                            return longestPrefix.ToString();
                        }
                    }
                }

                longestPrefix.Append(anchorLetter);
            }

            return longestPrefix.ToString();
        }
    }
}
