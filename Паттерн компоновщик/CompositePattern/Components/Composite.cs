using System;

namespace CompositePattern.Components
{
    class Composite : Component
    {
        protected List<Component> _children = new List<Component>();

        public override void Add(Component component)
        {
            this._children.Add(component);
        }

        public override void Remove(Component component)
        {
            this._children.Remove(component);
        }

        public override string Operation()
        {
            string result = "Branch(";

            int i = 0;

            foreach(Component component in this._children){
                result += component.Operation();
                if ( i != this._children.Count - 1)
                {
                    result += " + ";
                }
                i++;
            }

            return result +  ")";            
        }

    }
}