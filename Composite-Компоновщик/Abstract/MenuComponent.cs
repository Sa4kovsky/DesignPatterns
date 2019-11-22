using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite_Компоновщик.Iterators;

namespace Composite_Компоновщик.Abstract
{
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual MenuComponent GetChild(int i)
        {
            throw new NotSupportedException();
        }

        // методы которые реализует MenuItems - класс листового узла , на диаграме классов это компоновщик
        public virtual string Name => throw new NotSupportedException();
        public virtual string Description => throw new NotSupportedException();
        public virtual double Price => throw new NotSupportedException();
        public virtual bool IsVegetarian => throw new NotSupportedException();

        public virtual void Print()
        {
            throw new NotSupportedException();
        }

        public virtual IEnumerator<MenuComponent> CreateEnumerator()
        {
            return new NullEnumerator();
        } 

    }
}
