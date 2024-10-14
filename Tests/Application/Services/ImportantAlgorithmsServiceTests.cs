using InterviewPreparation.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Application.Services
{
    public class ImportantAlgorithmsServiceTests
    {
        [Fact]
        public void PartitionTheArray()
        {
            var service = new ImportantAlgorithmsService();
            var items = new int[] { 9, 7, 5, 3, 8, 2, 1 };

            items = service.PartitionTheArray(items);
            Assert.Equal(1, items[0]);
            Assert.Equal(7, items[1]);
            Assert.Equal(5, items[2]);
            Assert.Equal(3, items[3]);
            Assert.Equal(8, items[4]);
            Assert.Equal(2, items[5]);
            Assert.Equal(9, items[6]);

            items = [1, 6, 8, 3, 2, 4, 5];

            items = service.PartitionTheArray(items);
            Assert.Equal(1, items[0]);
            Assert.Equal(3, items[1]);
            Assert.Equal(2, items[2]);
            Assert.Equal(4, items[3]);
            Assert.Equal(5, items[4]);
            Assert.Equal(6, items[5]);
            Assert.Equal(8, items[6]);
        }

        [Fact]
        public void Rotate()
        {
            var service = new ImportantAlgorithmsService();
            var items = new int[] { 9, 7, 5, 3, 8, 2, 1 };

            items = service.Rotate(items, 3);
            Assert.Equal(8, items[0]);
            Assert.Equal(2, items[1]);
            Assert.Equal(1, items[2]);
            Assert.Equal(9, items[3]);
            Assert.Equal(7, items[4]);
            Assert.Equal(5, items[5]);
            Assert.Equal(3, items[6]);
        }

        [Fact]
        public void ReverseString()
        {
            var service = new ImportantAlgorithmsService();
            var str = "algorithm";

            var strReverse = service.ReverseString(str);
            Assert.Equal("mhtirogla", strReverse);
        }

        [Fact]
        public void IsPalindrome()
        {
            var service = new ImportantAlgorithmsService();
            var str = "A man a plan a canal Panama";

            var IsPalindrome = service.IsPalindrome(str);
            Assert.True(IsPalindrome);
        }

        [Fact]
        public void IsAnagram()
        {
            var service = new ImportantAlgorithmsService();
            var str = "listen";
            var str2 = "silent";

            var isAnagram = service.IsAnagram(str, str2);
            Assert.True(isAnagram);

            str = "hello";
            str2 = "world";

            isAnagram = service.IsAnagram(str, str2);
            Assert.False(isAnagram);
        }
    }
}
