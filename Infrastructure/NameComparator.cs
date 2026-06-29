
public class NameComparator : IComparer<Person>
{
    public int Compare(Person? x, Person? y)
    {
        int xSum = x.FirstName.Length + x.LastName.Length;
        int ySum = y.FirstName.Length + y.LastName.Length;

        return xSum.CompareTo(ySum);
    }
}
