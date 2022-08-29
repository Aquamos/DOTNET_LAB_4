using LAB4.Models;

namespace LAB4.Business
{
    public class Squad: Component
    {
        public override int Power 
        { 
            get 
            {
                int totalPower = 0;
                foreach (Component component in this._children)
                {
                    totalPower += component.Power;
                }

                return totalPower;
            } 
        }
        protected List<Component> _children = new List<Component>();

        public override void Add(Component component)
        {
            this._children.Add(component);
        }

        public override void Remove(Component component)
        {
            this._children.Remove(component);
        }
    }
}
