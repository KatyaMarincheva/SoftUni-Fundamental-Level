namespace _04.SULS.Interfaces
{
    interface IPerson
    {
        string FirstName { get; }

        string LastName { get; }

        int Age { get; }

        string ToString();
    }
}
