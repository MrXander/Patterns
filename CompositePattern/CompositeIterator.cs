using System;
using System.Collections;

namespace CompositePattern
{
    class CompositeIterator: IEnumerator
    {
        private readonly Stack _stack = new Stack();

        public CompositeIterator(IEnumerator iterator)
        {
            _stack.Push(iterator);
        }

        public bool MoveNext()
        {
            if (_stack.Count == 0)
                return false;

            var iterator = (IEnumerator) _stack.Peek();
            if (iterator.MoveNext())
            {
                _stack.Pop();
                return MoveNext();
            }

            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public object Current {
            get
            {
                if (MoveNext())
                {
                    var iterator = (IEnumerator)_stack.Peek();
                    var component = (MenuComponent)iterator.Current;
                    if (component is Menu)
                    {
                        _stack.Push(component.CreateIterator());
                    }
                    return component;
                }
                return null;
            }
            private set
            {
                throw new NotImplementedException();
            }}
    }
}
