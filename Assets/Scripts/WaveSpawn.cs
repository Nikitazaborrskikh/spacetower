using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WaveSpawn : MonoBehaviour
{
    [SerializeField] private GameObject enemyprefab;
    [SerializeField] private Transform SpawnPoint;
    private float _TimeBtwWaves = 10f;
    private float _countdown = 2f;
    private int _wavenumber = 0;
    public int wavecount = 0;
    
    [SerializeField] private Text text;

    public int whatLevel;
    public int whatColor;

    private void Update()
    {
        CheckWin(_wavenumber , wavecount);
        if(_countdown <= 0)
        {
            StartCoroutine(Spawn());
            _countdown = _TimeBtwWaves;
        }
        _countdown -= Time.deltaTime;
        text.text = Mathf.Round(_countdown).ToString();
    }
    IEnumerator Spawn()
    {
        _wavenumber++;
        for (int i = 0; i < _wavenumber; i++)
        {
            
            SpawnEnemy();
            yield return new WaitForSeconds(2f);
        }
        
    }
    void SpawnEnemy()
    {
        
        Instantiate(enemyprefab, SpawnPoint.position, SpawnPoint.rotation);
    }

    public void CheckWin(int wavenumber, int LevelWave)
    {
        if (wavenumber == LevelWave)
        {
            UnLockLevel();
            SceneManager.LoadScene("WinSceane");
            
        }
    }

    public void UnLockLevel()
    {
        

        if (whatLevel >= PlayerPrefs.GetInt("levelUnLock"))
        {
            Debug.Log("sdssds");
            PlayerPrefs.SetInt("levelUnLock", whatLevel + 1);
        }
        if (whatColor >= PlayerPrefs.GetInt("imageColor"))
        {
            Debug.Log("cvbcvbcb");
            PlayerPrefs.SetInt("imageColor", whatColor + 1);
        }
    }

    void CheckEnemies()
    {
        if (!GameObject.FindWithTag("Enemy"))
        {
            
        }
    }
    
}
