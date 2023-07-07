using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisitorPattern_Before
{
    public interface IAnimal
    {
        public void MakeSound();
        public void Feed();
        public void Pet();
    }

    public class Cat : IAnimal
    {
        public void MakeSound() => Debug.Log("Meow!");
        public void Feed() => Debug.Log("Feed the cat");
        public void Pet() => Debug.Log("Pet the cat");
    }

    public class Dog : IAnimal
    {
        public void MakeSound() => Debug.Log("Woof!");
        public void Feed() => Debug.Log("Feed the dog");
        public void Pet() => Debug.Log("Pet the dog");
    }

    public class Cow : IAnimal
    {
        public void MakeSound() => Debug.Log("Mooo!");
        public void Feed() => Debug.Log("Feed the cow");
        public void Pet() => Debug.Log("Pet the cow");
    }
}