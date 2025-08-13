using System.Collections.Generic;
using Sources._Project.Sources.Runtime.Gameplay.MiniGames.States;
using Sources.Runtime.Gameplay.MiniGames.Root;
using Sources.Runtime.Gameplay.MiniGames.States;
using UnityEngine;

namespace Sources.Runtime.Gameplay.MiniGames
{
    public sealed class MiniGamesBootstrapper
    {
        private Core.StateMachine.StateMachine _stateMachine;
        private ShowTaskState _showTaskState;
        
        private List<IMiniGame> _allMiniGames;

        public void Initialize()
        {
            _stateMachine = new Core.StateMachine.StateMachine();
            _showTaskState = new ShowTaskState();
            
            _stateMachine.Register(_showTaskState);
            _stateMachine.Register(new AnsweringState());
            _stateMachine.Register(new CheckResultState());
        }

        public void Launch()
        {
            _showTaskState.Initialize(GetRandomMiniGame());
            
            _stateMachine.Enter<ShowTaskState>();
        }

        private IMiniGame GetRandomMiniGame()
        {
            int miniGamesCount = _allMiniGames.Count;
            int randomMiniGameIndex = Random.Range(0, miniGamesCount);
            
            return _allMiniGames[randomMiniGameIndex];
        }
    }
}