namespace InterviewPreparation.Application.Services
{
    public class ImportantAlgorithmsService
    {
        /*
        Given the input array, the last item is a pivot. 
        You must position it within the array so that all elements on the left are smaller and all on the right are larger. 
        You should not use auxiliary arrays.
        Keep it O(n).
        */
        public int[] PartitionTheArray(int[] items)
        {
            var pivo = items[items.Length - 1];
            var i = -1;

            for (var j = 0; j < items.Length - 1; j++)
            {
                var item = items[j];
                if (items[j] <= pivo)
                {
                    i++;
                    Swap(items, i, j);
                }
            }

            Swap(items, i + 1, items.Length - 1);

            return items;
        }

        /*
        Given the input array, rotate it for k positions.
        You should not use auxiliary arrays.
        Keep it O(n).
         */
        public int[] Rotate(int[] items, int k)
        {
            var n = items.Length;
            k = k % n;

            reverse(items, 0, n - 1);

            reverse(items, 0, k - 1);

            reverse(items, k, n - 1);
            
            return items;
        }

        /*
        Given a string, reverse its characters. The algorithm should operate in-place, if possible, and be efficient.
        Keep it O(n).
        */
        public string ReverseString(string str)
        {
            var splitedStr = str.ToCharArray();
            var start = 0;
            var end = str.Length - 1;

            while (start < end)
            {
                var temp = splitedStr[start];
                splitedStr[start] = splitedStr[end];
                splitedStr[end] = temp;
                start++;
                end--;
            }

            return new string(splitedStr);
        }

        /*
        Given a string, check if it is a palindrome. 
        A string is considered a palindrome if it can be read the same way forward and backward, ignoring spaces, punctuation, and case differences.
        */
        public bool IsPalindrome(string  str)
        {
            str = str.ToLower();
            str = str.Trim();
            str = str.Replace(" ", string.Empty);
            var strToValidate = str.ToCharArray();

            var start = 0;
            var end = strToValidate.Length - 1;

            while (start < end)
            {
                if (strToValidate[start] != strToValidate[end]) {
                    return false;
                }

                start++;
                end--;
            }

            return true;
        }

        /*
        Given two strings, determine whether one is an anagram of the other. 
        Two strings are considered anagrams if they can be rearranged to form the same string, 
        that is, both must contain exactly the same characters with the same frequencies.
        */
        public bool IsAnagram(string str, string str2) 
        {
            if (str.Length != str2.Length)
            {
                return false;
            }

            var strSplited = str.ToCharArray();
            var str2Splited = str2.ToCharArray();

            var anagramChecker = new Dictionary<char, int>();
            for (int i = 0; i < strSplited.Length; i++)
            {
                if (anagramChecker.ContainsKey(strSplited[i]))
                {
                    anagramChecker[strSplited[i]]++;
                }
                else
                {
                    anagramChecker.Add(strSplited[i], 1);
                }
            }

            for (int i = 0; i < str2Splited.Length; i++)
            {
                if (anagramChecker.ContainsKey(str2Splited[i]))
                {
                    if (anagramChecker[str2Splited[i]] == 0)
                    {
                        return false;
                    }

                    anagramChecker[str2Splited[i]]--;
                    if (anagramChecker[str2Splited[i]] == 0)
                    {
                        anagramChecker.Remove(str2Splited[i]);
                    }
                }
                else
                {
                    return false;
                }
            }

            return anagramChecker.Count == 0;
        }

        private void reverse(int[] items, int start, int end)
        {
            while (start < end)
            {
                var temp = items[start];
                items[start] = items[end];
                items[end] = temp;
                start++;
                end--;
            }
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
