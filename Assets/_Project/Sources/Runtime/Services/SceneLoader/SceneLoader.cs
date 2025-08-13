using Cysharp.Threading.Tasks;
using Sources.Runtime.Utils;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sources.Runtime.Services.SceneLoader
{
    public class SceneLoader : ISceneLoader
    {
        public void LoadScene(string sceneToLoadName) => LoadSceneAsync(sceneToLoadName).Forget();

        public async UniTask LoadSceneAsync(string sceneToLoadName)
        {
            string sceneName = sceneToLoadName.ToString();

            AsyncOperation loadSceneOperation = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);

            await loadSceneOperation.ToUniTask();

            SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneName));
        }
    }
}