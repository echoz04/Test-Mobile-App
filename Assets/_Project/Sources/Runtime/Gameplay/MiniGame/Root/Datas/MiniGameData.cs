using System.Collections.Generic;
using UnityEngine;

namespace Sources.Runtime.Gameplay.MiniGame.Root.Datas
{
    [CreateAssetMenu(fileName = "MiniGameData", menuName = "Datas/New Mini Game Data")]
    public sealed class MiniGameData : ScriptableObject
    {
        public IReadOnlyList<MiniGameTask> Tasks => _tasks;

        [SerializeField] private List<MiniGameTask> _tasks;
    }
}