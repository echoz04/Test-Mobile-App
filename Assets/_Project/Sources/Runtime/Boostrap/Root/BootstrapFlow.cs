using Sources.Runtime.Services.GameDataLoader;
using Sources.Runtime.Services.SceneLoader;
using Sources.Runtime.Utils;
using UnityEngine;
using VContainer.Unity;

namespace Sources.Runtime.Boostrap.Root
{
    public class BootstrapFlow : IStartable
    {
        private const string _sceneToLoad = SceneConstants.Gameplay;
        
        private readonly ISceneLoader _sceneLoader;

        private BootstrapFlow(ISceneLoader sceneLoader)
        {
            _sceneLoader = sceneLoader;
        }

        public async void Start()
        {
            await _sceneLoader.LoadSceneAsync(_sceneToLoad);
        }
    }
}