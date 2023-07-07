namespace InterfaceSegregationPrinciple_Before
{
    public class Bird : ICharacter
    {
        public void Walk()
        {
        }

        public void Swim()
        {
            //bird can't swim but still needs to implement the swim function
        }

        public void Fly()
        {
        }
    }
}