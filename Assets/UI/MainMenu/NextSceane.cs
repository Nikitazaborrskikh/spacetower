using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceane : MonoBehaviour
{
    public void NaxtLevel(int _sceneNumber)
    {       
        SceneManager.LoadScene(_sceneNumber);
    }
}
