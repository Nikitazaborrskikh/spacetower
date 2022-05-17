using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLobby : MonoBehaviour
{
    AsyncOperation asyncOperation;
    [SerializeField] private Image _loadBar;
    [SerializeField] private Text _loadText;

    private void Awake()
    {
        StartCoroutine(LoadSceaneCor());
    }

    IEnumerator LoadSceaneCor()
    {
        yield return new WaitForSeconds(3f);
        asyncOperation = SceneManager.LoadSceneAsync("Nikitatest");

        while (!asyncOperation.isDone)
        {
            float progress = asyncOperation.progress / 0.9f;
            _loadBar.fillAmount = progress;
            _loadText.text = "Loading" + string.Format("{0:0}%", progress * 100f);

            yield return 0;
        }
    }
}
