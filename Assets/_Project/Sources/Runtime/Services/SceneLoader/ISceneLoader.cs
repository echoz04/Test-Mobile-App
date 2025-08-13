using Cysharp.Threading.Tasks;
using Sources.Runtime.Utils;

namespace Sources.Runtime.Services.SceneLoader
{
    public interface ISceneLoader
    {
        void LoadScene(string scene);

        UniTask LoadSceneAsync(string scene);
    }
}