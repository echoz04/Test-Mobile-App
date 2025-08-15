using System.Collections.Generic;
using UnityEngine;

namespace Sources.Runtime.Gameplay.MiniGame.Root.Datas
{
    [System.Serializable]
    public struct MiniGameTask
    {
        public string QuestionText => _questionText;
        public IReadOnlyList<string> Answers => _answers;
        public int CorrectAnswerIndex => _correctAnswerIndex;
        
        [SerializeField] private string _questionText;
        [SerializeField] private string[] _answers;
        [SerializeField] private int _correctAnswerIndex;
    }
}