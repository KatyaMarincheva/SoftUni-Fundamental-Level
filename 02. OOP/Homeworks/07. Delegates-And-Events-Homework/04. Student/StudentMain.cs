namespace _04.Student
{
    using System;

    public class StudentMain
    {
        public static void Main(string[] args)
        {
            Student student = new Student("Ekaterina", 22);

            student.PropertyChanged += (sender, eventArgs) =>
            {
                Console.WriteLine(
                    "Property changed: {0} (from {1} to {2})",
                    eventArgs.PropertyName,
                    eventArgs.OldValue,
                    eventArgs.NewValue);
            };

            student.Name = "Katya";
            student.Age = 52;
        }
    }
}
