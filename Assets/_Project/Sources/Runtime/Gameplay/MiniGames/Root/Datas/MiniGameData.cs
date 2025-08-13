using System.Collections.Generic;
using UnityEngine;

namespace Sources.Runtime.Gameplay.MiniGames.Root.Datas
{
    [CreateAssetMenu(fileName = "MiniGameData", menuName = "Datas/New Mini Game Data")]
    public class MiniGameData : ScriptableObject
    {
        public IReadOnlyList<MiniGameTask> Tasks => _tasks;
        
        [SerializeField] private List<MiniGameTask> _tasks = new();
    }
}