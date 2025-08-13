using UnityEngine;
using VContainer.Unity;

namespace Sources.Runtime.Gameplay.Root
{
    public class GameplayFlow : IStartable
    {
        public void Start()
        {
            Debug.Log("Hello World!");
        }
    }
}