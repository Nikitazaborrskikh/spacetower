using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] private GameObject _canvasSetting;
    [SerializeField] private GameObject _canvasMainMenu;

    public void OpenSettings()
    {
        _canvasMainMenu.SetActive(false);
        _canvasSetting.SetActive(true);
    }

    public void CloseSettings()
    {
        _canvasMainMenu.SetActive(true);
        _canvasSetting.SetActive(false);
    }
}
