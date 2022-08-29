using LAB4.Business;


namespace LAB4.Models
{
    public abstract class Unit: Component
    {
        public abstract override int Power { get;}
       
        public override bool IsComposite { get; } = false;
    }
}
