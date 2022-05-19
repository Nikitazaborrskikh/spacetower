using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UnlockLevels : MonoBehaviour
{
    //private int levelUnLock;
    public Button[] buttons;
    public Image[] images;

    void Start()
    {
        int levelUnLock = PlayerPrefs.GetInt("levelUnLock", 1);

        for (int i = 0; i < buttons.Length; i++)
        {
            if (i + 1 > levelUnLock)
            {
                buttons[i].interactable = false;
            }            
        }

        int imageColor = PlayerPrefs.GetInt("imageColor", 0);

        for (int i = 0; i < images.Length; i++)
        {
            if (i + 1 > imageColor)
            {
                images[i].color = Color.clear;
            }
        }

        //for (int i = 0; i < levelUnLock; i++)
        //{
        //    buttons[i].interactable = true;
        //}
    }

    public void ResetLevel()
    {
        for (int i = 1;i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
            PlayerPrefs.DeleteAll();
        }
    }

    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
}
