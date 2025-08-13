using Cysharp.Threading.Tasks;
using Sources.Runtime.Game;
using Sources.Runtime.Utils;
using UnityEngine.AddressableAssets;

namespace Sources.Runtime.Services.GameDataLoader
{
    public class GameDataLoader : IGameDataLoader
    {
        public GameData Data { get; private set; }

        public async UniTask LoadGameDataAsync()
        {
            var handle = Addressables.LoadAssetAsync<GameData>(AssetConstants.GameData);
            
            Data = await handle.ToUniTask();
        }
    }
}