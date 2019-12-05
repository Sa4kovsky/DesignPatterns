

namespace Duck.Abstract
{
    public abstract class AbstractDuckFactory
    {
        public abstract IQuackable CreateMallarDuck();
        public abstract IQuackable CreateRedheadDuck();
        public abstract IQuackable CreateDuckCall();
        public abstract IQuackable CreateRubberDuck();
    }
}
