using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Sources.Runtime.Boostrap.Root
{
    public class BootstrapScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<BootstrapFlow>();
        }
    }
}