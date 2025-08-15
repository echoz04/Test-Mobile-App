using Sources.Runtime.Gameplay.MiniGame.Root.Datas;
using Sources.Runtime.Gameplay.MiniGame.Root.States;
using TMPro;
using UnityEngine;
using VContainer;

namespace Sources.Runtime.Gameplay.MiniGame
{
    public class MiniGameView : MonoBehaviour
    {
        [SerializeField] private GameObject _panel;
        [SerializeField] private TextMeshProUGUI _questionText;
        [SerializeField] private TextMeshProUGUI[] _answers;
        
        private MiniGamesBootstrapper  _bootstrapper;
        
        [Inject]
        private void Construct(MiniGamesBootstrapper bootstrapper)
        {
            _bootstrapper = bootstrapper;
        }

        private void Start()
        {
            Debug.Log("View.Start");
            
            _bootstrapper.OnLaunched += ShowPanel;
        }

        private void OnDestroy()
        {
            _bootstrapper.OnLaunched -= ShowPanel;
        }

        private void ShowPanel()
        {
            _panel.SetActive(true);
            
            _bootstrapper.ShowTaskState.OnEntered += ShowTaskInfo;
        }

        private void ShowTaskInfo(MiniGameTask task)
        {
            _questionText.text = task.QuestionText;

            for (int i = 0; i < task.Answers.Count; ++i)
            {
                if(i < _answers.Length)
                    _answers[i].text = task.Answers[i];
            }
        }
    }
}