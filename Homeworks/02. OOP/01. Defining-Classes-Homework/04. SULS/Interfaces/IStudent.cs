namespace _04.SULS.Interfaces
{
    internal interface IStudent : IPerson
    {
        int StudentNumber { get; }

        double AverageGrade { get; }
    }
}
