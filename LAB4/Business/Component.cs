
namespace LAB4.Business
{
    public abstract class Component
    {
        public abstract int Power { get; }
        public virtual bool IsComposite { get; } = true;
        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
