namespace _02.Animals.Interfaces
{
    using Enums;

    interface IAnimal : ISoundProducible
    {
        string Name { get; set; }
        int Age { get; set; }
        Gender Gender { get; set; }
    }
}
