using UnityEngine;

namespace VisitorPattern_After
{
    public interface IAnimalVisitor
    {
        void VisitCat(Cat cat);
        void VisitDog(Dog dog);
        void VisitCow(Cow cow);
    }

    public class MakeSoundVisitor : IAnimalVisitor
    {
        public void VisitCat(Cat cat) => Debug.Log("Meow!");
        public void VisitDog(Dog dog) => Debug.Log("Woof!");
        public void VisitCow(Cow cow) => Debug.Log("Mooo!");
    }

    public class FeedVisitor : IAnimalVisitor
    {
        public void VisitCat(Cat cat) => Debug.Log("Feed the cat");
        public void VisitDog(Dog dog) => Debug.Log("Feed the dog");
        public void VisitCow(Cow cow) => Debug.Log("Feed the cow");
    }

    public class PetVisitor : IAnimalVisitor
    {
        public void VisitCat(Cat cat) => Debug.Log("Pet the cat");
        public void VisitDog(Dog dog) => Debug.Log("Pet the dog");
        public void VisitCow(Cow cow) => Debug.Log("Pet the cow");
    }
}