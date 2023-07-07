using System.Collections.Generic;

namespace VisitorPattern_After
{
    public class Zoo
    {
        public List<IAnimal> OneOfEachAnimals() => new List <IAnimal> { new Cat(), new Dog(), new Cow() };

        public void MakeAllAnimalsSound(List<IAnimal> animals)
        {
            foreach (IAnimal animal in animals)
                animal.Accept(new MakeSoundVisitor());
        }

        public void FeedAllAnimals(List<IAnimal> animals)
        {
            foreach (IAnimal animal in animals)
                animal.Accept(new FeedVisitor());
        }

        public void PetAllAnimals(List<IAnimal> animals)
        {
            foreach (IAnimal animal in animals)
                animal.Accept(new PetVisitor());
        }
    }
}