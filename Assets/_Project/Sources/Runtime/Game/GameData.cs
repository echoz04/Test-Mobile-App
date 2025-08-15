using System.Collections.Generic;
using Sources.Runtime.Gameplay.MiniGame.Root.Datas;
using UnityEngine;

namespace Sources.Runtime.Game
{
    [CreateAssetMenu(fileName = "GameData", menuName = "Datas/New Game Data")]
    public class GameData : ScriptableObject
    {
        public IReadOnlyList<MiniGameData> AllMiniGameDatas => _allMiniGameDatas;

        [SerializeField] private List<MiniGameData> _allMiniGameDatas;
    }
}