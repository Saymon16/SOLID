namespace InterfaceSegregationPrinciple_Before
{
    public class Human : ICharacter
    {
        public void Walk()
        {
        }

        public void Swim()
        {
        }

        public void Fly()
        {
            //bird can't fly but still needs to implement the fly function
        }
    }
}