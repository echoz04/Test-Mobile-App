using Sources.Runtime.Gameplay.MiniGames;
using Sources.Runtime.Services.GameDataLoader;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Sources.Runtime.Gameplay.Root
{
    public sealed class GameplayScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<GameplayFlow>();

            builder.Register<MiniGamesBootstrapper>(Lifetime.Singleton)
                .AsSelf();
        }
    }
}