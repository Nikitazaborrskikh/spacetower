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
            SceneManager.LoadScene("WinSceane");
            //int currentLevel = SceneManager.GetActiveScene().buildIndex;

            //if (currentLevel >= PlayerPrefs.GetInt("levels"))
            //{
            //    PlayerPrefs.SetInt("levels", currentLevel + 1);
            //}
        }
    }

    void CheckEnemies()
    {
        if (!GameObject.FindWithTag("Enemy"))
        {
            
        }
    }
    
}
