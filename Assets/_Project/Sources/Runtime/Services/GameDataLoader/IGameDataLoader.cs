using Cysharp.Threading.Tasks;
using Sources.Runtime.Game;

namespace Sources.Runtime.Services.GameDataLoader
{
    public interface IGameDataLoader
    {
        GameData Data { get; }
        
        UniTask LoadGameDataAsync();
    }
}