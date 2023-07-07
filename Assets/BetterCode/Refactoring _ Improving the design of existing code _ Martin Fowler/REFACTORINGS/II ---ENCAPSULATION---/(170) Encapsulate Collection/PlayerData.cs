using System.Collections.Generic;

namespace EncapsulateCollection_Before
{
    public class Player
    {
        public List<string> Inventory = new List<string>();
    }
}

namespace EncapsulateCollection_After
{
    public class Player
    {
        private List<string> _inventory = new List<string>();

        public void AddItem(string item)
        {
            // You can add checks here if needed, for example:
            if (!_inventory.Contains(item))
            {
                _inventory.Add(item);
            }
        }

        public void RemoveItem(string item)
        {
            _inventory.Remove(item);
        }

        public bool HasItem(string item)
        {
            return _inventory.Contains(item);
        }

        public IEnumerable<string> GetItems()
        {
            // Returning a copy of inventory to maintain control over the original collection
            return new List<string>(_inventory);
        }
    }
}