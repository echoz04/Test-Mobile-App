using Sources.Runtime.Gameplay.MiniGame.Root.Datas;
using Sources.Runtime.Gameplay.MiniGame.Root.States;
using Sources.Runtime.Services.GameDataLoader;
using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Sources.Runtime.Gameplay.MiniGame
{
    public sealed class MiniGamesBootstrapper
    {
        public event Action OnLaunched;
        
        public ShowTaskState ShowTaskState {  get; private set; }

        private Core.StateMachine.StateMachine _stateMachine;
        
        private IGameDataLoader _gameDataLoader;

        private MiniGamesBootstrapper(IGameDataLoader gameDataLoader)
        {
            _gameDataLoader = gameDataLoader;
        }

        public void Initialize()
        {
            _stateMachine = new Core.StateMachine.StateMachine();
            ShowTaskState = new ShowTaskState();
            
            _stateMachine.Register(ShowTaskState);
            _stateMachine.Register(new AnsweringState());
            _stateMachine.Register(new CheckResultState());
        }

        public void Launch()
        {
            OnLaunched?.Invoke();
            
            ShowTaskState.Initialize(GetRandomMiniGameData());
            
            _stateMachine.Enter<ShowTaskState>();
        }

        private MiniGameData GetRandomMiniGameData()
        {
            var allMiniGameDatas = _gameDataLoader.Data.AllMiniGameDatas;
            int miniGamesCount = allMiniGameDatas.Count;
            int randomMiniGameIndex = Random.Range(0, miniGamesCount);
            
            return allMiniGameDatas[randomMiniGameIndex];
        }
    }
}