using System;
using Secyud.Ugf.DependencyInjection;
using Secyud.Ugf.Prefab;
using UnityEngine;

namespace Secyud.Ugf.UserInterface
{
    public abstract class PrefabControllerBase : ISingleton
    {
        internal PrefabDescriptor PrefabDescriptor { get; set; }
        
        public string Name { get; protected set; }

        public virtual Type ParentType => null;

        internal Func<PrefabControllerBase,PrefabControllerBase> ParentFactory { get; set; }

        public PrefabControllerBase Parent => ParentFactory(this);
        
        protected GameObject PanelObject => PrefabDescriptor.Instance;

        protected TComponent GetComponent<TComponent>()
            where TComponent : Component
            => PrefabDescriptor.Instance.GetComponent<TComponent>();


        public virtual void OnInitialize()
        {
        }

        public virtual void OnShutDown()
        {
        }
        
        protected PrefabControllerBase()
        {
            var className = GetType().Name;
            Name = className.EndsWith("Controller") ? className[..^"Controller".Length] : className;
        }
    }
}