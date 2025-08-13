using Sources.Runtime.Services.GameDataLoader;
using Sources.Runtime.Services.SceneLoader;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Sources.Runtime.Game.Root
{
    public class GameScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<GameDataLoader>(Lifetime.Singleton)
                .As<IGameDataLoader>();

            builder.Register<SceneLoader>(Lifetime.Singleton)
                .As<ISceneLoader>();
        }
    }
}