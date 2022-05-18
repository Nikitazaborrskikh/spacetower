using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOptions : MonoBehaviour
{
    [SerializeField] private AudioSource _musicSource;

    private float _volume = 1.0f;

    private void Update()
    {
        _musicSource.volume = _volume;
    }

    public void SetVolume(float vol)
    {
        _volume = vol;
    }
}
