namespace InterviewPreparation.Domain.Entities.Arrays
{
    public class Algorithm
    {
        /**
        Given an array arr[] of n integers and a target value, 
        the task is to find whether there is a pair of elements in the array whose sum is equal to target.
        **/
        public static bool PairWithGivenSum(int[] items, int target)
        {
            var processedItems = new Dictionary<int, int>();

            for (int i = 0; i < items.Length; i++)
            {
                var item = items[i];
                var difference = target - item;
                if (processedItems.ContainsKey(difference))
                {
                    return true;
                } else
                {
                    if (!processedItems.ContainsKey(item))
                    {
                        processedItems.Add(item, i);
                    }
                }
            }

            return false;
        }

        /**
        Given an array prices[] of length N, representing the prices of the stocks on different days, 
        the task is to find the maximum profit possible by buying and selling the stocks on different days when at most one transaction is allowed. 
        Here one transaction means 1 buy + 1 Sell.
        Note: Stock must be bought before being sold.
        **/
        public static int StockBuyAndSell(int[] prices) 
        {
            var bestSell = new Tuple<int, int>(0, 0);
            var buy = prices[0];
            var sell = prices[1];
            if (buy > sell)
            {
                buy = sell;
                sell = 0;
            } else
            {
                bestSell = new Tuple<int, int>(buy, sell);
            }

            for (int i = 2; i < prices.Length; i++)
            {
                var item = prices[i];
                if (buy > item)
                {
                    buy = item;
                    sell = 0;
                } else if (sell < item)
                {
                    sell = item;
                    var currentProfit = bestSell.Item2 - bestSell.Item1;
                    var newProfit = sell - buy;
                    if (newProfit > currentProfit)
                    {
                        bestSell = new Tuple<int, int>(buy, sell);
                    }
                }
            }

            return bestSell.Item2 - bestSell.Item1;
        }

        /**
        Given an array of n elements that contains elements from 0 to n-1, 
        with any of these numbers appearing any number of times. 
        Find these repeating numbers in O(n) and use only constant memory space.
        Note: The repeating element should be printed only once.
        **/
        public static List<int> FindDuplicates(int[] numbers)
        {
            var duplicatesCounter = new Dictionary<int, int>();
            var results = new List<int>();

            foreach (var n in numbers)
            {
                if (duplicatesCounter.ContainsKey(n))
                {
                    duplicatesCounter[n]++;
                }
                else
                {
                    duplicatesCounter.Add(n, 1);
                }
            }

            foreach (var item in duplicatesCounter)
            {
                if (item.Value > 1)
                {
                    results.Add(item.Key);
                }
            }

            return results;
        }
    }
}
