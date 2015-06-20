namespace _04.SULS.Interfaces
{
    internal interface IPerson
    {
        string FirstName { get; }

        string LastName { get; }

        int Age { get; }

        string ToString();
    }
}
