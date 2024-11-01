using InterviewPreparation.Domain.Entities.Arrays;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Domain.Entities.Arrays
{
    public class AlgorithmTests
    {
        [Fact]
        public void PairWithGivenSum()
        {
            var input = new[] { 0, -1, 2, -3, 1 };
            var target = -2;

            var found = Algorithm.PairWithGivenSum(input, target);
            Assert.True(found);

            input = new[] { 1, -2, 1, 0, 5 };
            target = 0;

            found = Algorithm.PairWithGivenSum(input, target);
            Assert.False(found);
        }

        [Fact]
        public void StockBuyAndSell()
        {
            var input = new[] { 7, 10, 1, 3, 6, 9, 2 };
            var profit = Algorithm.StockBuyAndSell(input);
            Assert.Equal(8, profit);

            input = new[] { 7, 6, 4, 3, 1 };
            profit = Algorithm.StockBuyAndSell(input);
            Assert.Equal(0, profit);

            input = new[] { 1, 3, 6, 9, 11 };
            profit = Algorithm.StockBuyAndSell(input);
            Assert.Equal(10, profit);
        }

        [Fact]
        public void FindDuplicates()
        {
            var input = new[] { 1, 2, 3, 6, 3, 6, 1 };
            var result = Algorithm.FindDuplicates(input);
            Assert.Equal(3, result.Count);
            Assert.Equal(1, result[0]);
            Assert.Equal(3, result[1]);
            Assert.Equal(6, result[2]);

            input = new[] { 1, 2, 3, 4, 3 };
            result = Algorithm.FindDuplicates(input);
            Assert.Single(result);
            Assert.Equal(3, result[0]);
        }
    }
}
