namespace _04.SULS.Interfaces
{
    interface IStudent : IPerson
    {
        int StudentNumber { get; }

        double AverageGrade { get; }
    }
}
