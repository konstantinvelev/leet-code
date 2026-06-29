namespace LeetCode.Algorithms
{
    public class BinarySearch
    {
        // Binary search algorithm to find a person by age in a sorted list of people
        public int BinarySearchByAge(int targetAge, List<Person> people)
        {
            int left = 0;
            int right = people.Count - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (people[middle].Age == targetAge)
                {
                    Console.WriteLine(people[middle].FirstName + " " + people[middle].LastName);
                    return middle;
                }
                else if (people[middle].Age < targetAge)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return -1;
        }

        public int BinarySearchByNames(string targetName, List<Person> people)
        {
            int left = 0;
            int right = people.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int comparator = string.Compare(people[mid].FirstName, targetName);

                if (comparator == 0)
                {
                    Console.WriteLine(people[mid].FirstName + " " + people[mid].LastName);
                    return mid;
                }
                else if (comparator < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}
