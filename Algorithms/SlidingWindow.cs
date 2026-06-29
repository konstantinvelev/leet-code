public class SlidingWindow
{
    public int FixedWindow(List<Person> people, int windowSize)
    {

        int left = 0;
        int right = 0;
        int sum = 0;
        int maxSum = 0;

        while (right < people.Count)
        {
            sum += people[right].Age;

            if (right - left + 1 == windowSize)
            {
                maxSum = Math.Max(sum, maxSum);
                sum -= people[left].Age;
                left++;
            }

            right++;
        }

        return maxSum;
    }

    public int DynamicWindow(List<Person> people, int targetSum)
    {
        int left = 0;
        int right = 0;
        int sum = 0;
        int maxSum = 0;

        while (right < people.Count)
        {
            sum += people[right].Age;

            // It's really important to use while here instead of if, because we want to shrink the window until the condition is satisfied.
            while (sum >= targetSum)
            {
                sum -= people[left].Age;
                left++;
            }

            maxSum = Math.Max(sum, maxSum);
            right++;
        }

        return maxSum;
    }

    public int LengthOfLongestSubstring(string s)
    {
        int left = 0, right = 0, maxSum = 0;
        var letters = new char[128];

        while (right < s.Length)
        {
            char letter = s[right];
            letters[letter]++;

            // It's really important to use while here instead of if, because we want to shrink the window until the condition is satisfied.
            while (letters[letter] > 1)
            {
                letters[s[left]]--;
                left++;
            }

            maxSum = Math.Max(maxSum, right - left + 1);
            right++;
        }

        return maxSum;
    }

    public int BiggestSum(int[] numbers, int windowSize)
    {
        int left = 0, right = 0, maxSum = 0, sum = 0;

        while (right < numbers.Length)
        {
            sum += numbers[right];

            if (right - left >= windowSize)
            {
                maxSum = Math.Max(sum, maxSum);
                sum -= numbers[left];
                left++;
            }

            right++;
        }

        return maxSum;
    }

    public int BiggestSumUnderTarget(int[] numbers, int target)
    {
        int left = 0, right = 0, sum = 0, maxSum = 0;

        while (right < numbers.Length)
        {
            sum += numbers[right];
            while (sum >= target)
            {
                sum -= numbers[left];
                left++;
            }
            maxSum = Math.Max(sum, maxSum);
            right++;
        }

        return maxSum;
    }

    public int BiggestSubstring(string s, int k)
    {
        int left = 0, right = 0, sum = 0, maxSum = 0;
        Dictionary<char, int> letterCount = new Dictionary<char, int>();

        while (right < s.Length)
        {
            if (letterCount.ContainsKey(s[right]))
                letterCount[s[right]]++;
            else
                letterCount.Add(s[right], 1);

            while (letterCount.Count > k)
            {
                char leftChar = s[left];
                letterCount[leftChar]--;
                if (letterCount[leftChar] == 0)
                {
                    letterCount.Remove(leftChar);
                }
                left++;
            }

            maxSum = Math.Max(maxSum, right - left + 1);
            right++;
        }

        return maxSum;
    }

    public int ShortestCombinationAboveTarget(int[] numbers, int target)
    {
        int left = 0, right = 0, sum = 0, minLength = int.MaxValue;
        
        while(right < numbers.Length)
        {
            sum += numbers[right];

            while(sum >= target)
            {
                minLength = Math.Min(minLength, right - left + 1);
                sum -= numbers[left];
                left++;
            }

            right++;
        }
       return minLength == int.MaxValue ? 0 : minLength;
    }
}

