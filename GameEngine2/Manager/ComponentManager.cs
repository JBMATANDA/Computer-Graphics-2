using GameEngine2.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine2.Manager
{
    public class ComponentManager
    {
        private static ComponentManager cm;
        private int nextid;
        private Dictionary<Type, Dictionary<int, IComponent>> Components = new Dictionary<Type, Dictionary<int, IComponent>>();

        private ComponentManager(){}

        public static ComponentManager Get
        {
            get
            {
                if (cm == null)
                {
                    cm = new ComponentManager();
                }
                return cm;
            }
        }

        public int NewEntity()
        {
            return nextid++;
        }

        public T EntityComponent<T>(int id)
        {
           
            if (!Components.ContainsKey(typeof(T)))
            {
                Components.Add(typeof(T), new Dictionary<int, IComponent>());
            }

            var components = Components[typeof(T)];

            if (components.ContainsKey(id))
            {
                return (T)components[id];
            }
            else
            {
                return default(T);
            }
        }

        public Dictionary<int,IComponent> GetComponents<TComponentType>()
        {
            if (!Components.ContainsKey(typeof(TComponentType)))
            {
                Components.Add(typeof(TComponentType), new Dictionary<int, IComponent>());
            }
            return Components[typeof(TComponentType)];
        }

        public void AddComponentsToEntity(IComponent component, int id)
        {
            if (!Components.ContainsKey(component.GetType()))
            {
                Components.Add(component.GetType(), new Dictionary<int, IComponent>());
            }
            var components = Components[component.GetType()];
            components.Add(id, component);
        }
        public void RemoveComponents()
        {
            Components.Clear();
        }
    }
}
