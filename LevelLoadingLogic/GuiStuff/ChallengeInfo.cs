using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DoomahLevelLoader
{
    public class ChallengeInfo : MonoBehaviour
    {
        public string Challenge;
        public bool ActiveByDefault;

        [HideInInspector]
        public GameObject ChallengeText;

        public void Awake()
        {
            ChallengeText = Plugin.FindObjectEvenIfDisabled("Player", "Main Camera/HUD Camera/HUD/FinishCanvas/Panel/Challenge/ChallengeText");
            ChallengeText.GetComponent<TextMeshProUGUI>().text = Challenge;

            MonoSingleton<ChallengeManager>.Instance.challengeFailed = !ActiveByDefault; // THRICE?? i'm about to cry /j // nebula please don't unnecessarily "if" your scripts /info
            MonoSingleton<ChallengeManager>.Instance.challengeDone = ActiveByDefault;
        }
    }
}