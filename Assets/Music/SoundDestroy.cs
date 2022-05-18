using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDestroy : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
