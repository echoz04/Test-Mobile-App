using System;
using Sources.Runtime.Core.StateMachine;
using Sources.Runtime.Gameplay.MiniGame.Root.Datas;
using Random = UnityEngine.Random;

namespace Sources.Runtime.Gameplay.MiniGame.Root.States
{
    public class ShowTaskState : IState
    {
        public event Action<MiniGameTask> OnEntered;
        
        private MiniGameData _activeMiniGameData;
        
        public void Initialize(MiniGameData activeMiniGameData)
        {
            _activeMiniGameData = activeMiniGameData;
        }
        
        public void Enter()
        {
            var randomTask = GetRandomTask();
            
            OnEntered?.Invoke(randomTask);
        }

        public void Exit()
        {
        }

        private MiniGameTask GetRandomTask()
        {
            return _activeMiniGameData.Tasks[Random.Range(0, _activeMiniGameData.Tasks.Count)];
        }
    }
}