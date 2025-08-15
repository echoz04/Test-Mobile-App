using System;
using UnityEngine;
using UnityEngine.UI;
using VContainer;

namespace Sources.Runtime.Gameplay.MiniGame
{
    public class MiniGameLaunchButton : MonoBehaviour
    {
        [SerializeField] private Button _button;
        
        private MiniGamesBootstrapper _bootstrapper;

        private void OnValidate()
        {
            _button ??= GetComponent<Button>();
        }
        
        [Inject]
        private void Construct(MiniGamesBootstrapper bootstrapper)
        {
            _bootstrapper = bootstrapper;
        }

        private void Start()
        {
            _button.onClick.AddListener(() =>
            {
                _bootstrapper.Launch();
                gameObject.SetActive(false);
            });
        }
    }
}
