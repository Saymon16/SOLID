using UnityEngine;

namespace ReplacePrimitiveWithObject_Before
{
    public class Character
    {
        public int Health { get; set; }
    }
}

namespace ReplacePrimitiveWithObject_After
{
    public class Character
    {
        public Health Health { get; set; }
    }

    public class Health
    {
        private int _value;
        private int _maxValue;

        public int Value
        {
            get => _value;
            set => _value = Mathf.Clamp(value, 0, _maxValue);
        }

        public Health(int initialValue, int maxValue)
        {
            _maxValue = maxValue;
            _value = Mathf.Clamp(initialValue, 0, maxValue);
        }
    }
}