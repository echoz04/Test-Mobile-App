using System.Collections.Generic;
using Sources.Runtime.Gameplay.MiniGames.Root.Datas;
using UnityEngine;

namespace Sources.Runtime.Game
{
    [CreateAssetMenu(fileName = "GameData", menuName = "Datas/New Game Data")]
    public class GameData : ScriptableObject
    {
        [SerializeField] private List<MiniGameData> _allMiniGameDatas = new();
    }
}