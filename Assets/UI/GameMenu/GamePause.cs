using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePause : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;

    public void ReturneLevelSelect()
    {
        SceneManager.LoadScene("SelectLevel");
        Time.timeScale = 1;
    }

    public void PauseOn()
    {
        _pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void PauseOff()
    {
        _pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

}
