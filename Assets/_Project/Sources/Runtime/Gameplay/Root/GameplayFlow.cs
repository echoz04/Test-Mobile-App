using Sources.Runtime.Gameplay.MiniGame;
using Sources.Runtime.Services.GameDataLoader;
using UnityEngine;
using VContainer.Unity;

namespace Sources.Runtime.Gameplay.Root
{
    public class GameplayFlow : IStartable
    {
        private readonly IGameDataLoader _gameDataLoader;
        private readonly MiniGamesBootstrapper _miniGamesBootstrapper;
        
        private GameplayFlow(IGameDataLoader gameDataLoader, MiniGamesBootstrapper miniGamesBootstrapper)
        {
            _gameDataLoader = gameDataLoader;
            _miniGamesBootstrapper = miniGamesBootstrapper;
        }
        
        public async void Start()
        {
            await _gameDataLoader.LoadGameDataAsync();
            
            _miniGamesBootstrapper.Initialize();
            Debug.Log("GameplayScope.Configure");
        }
    }
}