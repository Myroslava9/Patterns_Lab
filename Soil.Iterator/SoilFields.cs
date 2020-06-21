using System.Collections;
using System.Collections.Generic;
using Soil.Iterator;
using Soil.Models.Interfaces;

namespace BLL.Iterator
{
    public class SoilFields : IteratorAggregate
    {
        List<ISoil> _collection = new List<ISoil>();

        bool _direction = false;

        public void ReverseDirection()
        {
            _direction = !_direction;
        }

        public List<ISoil> GetItems()
        {
            return _collection;
        }

        public void AddItem(ISoil item)
        {
            this._collection.Add(item);
        }

        public override IEnumerator GetEnumerator()
        {
            return new SoilIterator(this, _direction);
        }
    }
}
