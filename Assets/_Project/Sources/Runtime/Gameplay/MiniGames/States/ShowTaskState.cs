using Sources.Runtime.Core.StateMachine;
using Sources.Runtime.Gameplay.MiniGames.Root;

namespace Sources._Project.Sources.Runtime.Gameplay.MiniGames.States
{
    public class ShowTaskState : IState
    {
        private IMiniGame _activeMiniGame;
        
        public void Initialize(IMiniGame activeMiniGame)
        {
            _activeMiniGame = activeMiniGame;
        }
        
        public void Enter()
        {
        }

        public void Exit()
        {
        }
    }
}