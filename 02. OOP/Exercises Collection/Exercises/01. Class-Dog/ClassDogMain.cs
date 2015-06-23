namespace _01.Class_Dog
{
    class ClassDogMain
    {
        static void Main()
        {
            Dog unnamed = new Dog();
            Dog sharo = new Dog("Sharo", "Melez");

            unnamed.Breed = "German Shepherd";

            unnamed.Bark();
            sharo.Bark();
        }
    }
}
