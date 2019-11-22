using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite_Компоновщик.Abstract;
using Composite_Компоновщик.Menus;

namespace Composite_Компоновщик.Iterators
{
    public class CompositeEnumerator : IEnumerator<MenuComponent>
    {
        private readonly Stack<IEnumerator<MenuComponent>> _stack = new Stack<IEnumerator<MenuComponent>>();

        public CompositeEnumerator(IEnumerator<MenuComponent> enumerator)
        {
            _stack.Push(enumerator);
        }

        public bool MoveNext()
        {
            if (_stack.Count == 0)
            {
                return false;
            }

            var enumerator = _stack.Peek();
            if (!enumerator.MoveNext())
            {
                _stack.Pop();
                return MoveNext();
            }

            return true;
        }

        public MenuComponent Current
        {
            get
            {
                var enumerator = _stack.Peek();
                var menuComponent = enumerator.Current;
                if (menuComponent is Menu)
                {
                    _stack.Push(menuComponent.CreateEnumerator());
                }
                return menuComponent;
            }
        }

        object IEnumerator.Current => Current;

        public void Reset()
        {
            throw new NotSupportedException();
        }

        public void Dispose()
        {
        }
    }
}
