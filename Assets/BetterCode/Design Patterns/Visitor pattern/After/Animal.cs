using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisitorPattern_After
{
    public interface IAnimal
    {
        void Accept(IAnimalVisitor visitor);
    }

    public class Cat : IAnimal
    {
        public void Accept(IAnimalVisitor visitor) => visitor.VisitCat(this);
    }

    public class Dog : IAnimal
    {
        public void Accept(IAnimalVisitor visitor) => visitor.VisitDog(this);
    }

    public class Cow : IAnimal
    {
        public void Accept(IAnimalVisitor visitor) => visitor.VisitCow(this);
    }
}