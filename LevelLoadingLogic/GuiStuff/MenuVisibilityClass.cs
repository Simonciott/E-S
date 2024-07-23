using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

namespace DoomahLevelLoader
{
    public class MenuVisibilityClass : MonoBehaviour
    {
        private static MenuVisibilityClass instance;

        public Button AssignToMenuOpenButton;
        public Button AssignToGoBackButton;
        public GameObject AssignToFuckingLevels;

        public static MenuVisibilityClass Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = FindObjectOfType<MenuVisibilityClass>();
                    if (instance == null)
                    {
                        Debug.LogError("WOWZERS! SOMEONE FORGOT TO FIX THIS!");
                    }
                }
                return Instance;
            }
        }

        private void Start()
        {
            AssignToMenuOpenButton.onClick.AddListener(ToggleMenu);
            AssignToGoBackButton.onClick.AddListener(ToggleMenu);
        }

        private void ToggleMenu()
        {
            bool active = AssignToFuckingLevels.activeSelf; // nebula. using an if else for a bool? TWICE?? :(

            AssignToFuckingLevels.SetActive(!active);
            AssignToMenuOpenButton.gameObject.SetActive(active);
            MainMenuAgony.isAgonyOpen = !active;
            if(active)
                Debug.Log("open");
            else
                Debug.Log("close");
        }
    }
}