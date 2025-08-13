using Sources.Runtime.Utils;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sources.Runtime.Game.Root
{
    public class GameEntryPoint
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void AutostrapGame()
        {
            InitializeApplication();
            LoadBootstrapScene();
        }

        private static void InitializeApplication()
        {
            Application.targetFrameRate = 60;
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
        }

        private static void LoadBootstrapScene()
        {
#if UNITY_EDITOR
            var activeSceneName = SceneManager.GetActiveScene().name;
            var boostrapSceneName = SceneConstants.Bootstrap;

            if (activeSceneName != boostrapSceneName)
                SceneManager.LoadScene(boostrapSceneName);
#endif
        }
    }
}
