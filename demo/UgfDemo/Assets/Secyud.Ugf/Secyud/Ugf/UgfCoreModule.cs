using Secyud.Ugf.Modularity;
using Secyud.Ugf.Prefab;

namespace Secyud.Ugf
{
    public class UgfCoreModule : UgfModule
    {
        public override void PreConfigure(ConfigurationContext context)
        {
            context.Manager.AddType<PrefabManager>();
            context.Manager.AddType<PrefabControllerManager>();
        }
    }
}