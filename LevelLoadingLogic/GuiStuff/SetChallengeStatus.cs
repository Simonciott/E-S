using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DoomahLevelLoader
{
    public class SetChallengeStatus : MonoBehaviour
    {
        public bool Active;

        public void Awake()
        {
            MonoSingleton<ChallengeManager>.Instance.challengeFailed = !Active;
            MonoSingleton<ChallengeManager>.Instance.challengeDone = Active;
        }
    }
}