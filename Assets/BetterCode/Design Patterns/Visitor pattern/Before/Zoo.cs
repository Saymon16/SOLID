using System.Collections.Generic;

namespace VisitorPattern_Before
{
    public class Zoo
    {
        public List<IAnimal> OneOfEachAnimals() => new List <IAnimal> { new Cat(), new Dog(), new Cow() };

        public void MakeAllAnimalsSound(List<IAnimal> animals)
        {
            foreach (IAnimal animal in animals)
                animal.MakeSound();
        }

        public void FeedAllAnimals(List<IAnimal> animals)
        {
            foreach (IAnimal animal in animals)
                animal.Feed();
        }

        public void PetAllAnimals(List<IAnimal> animals)
        {
            foreach (IAnimal animal in animals)
                animal.Pet();
        }
    }
}