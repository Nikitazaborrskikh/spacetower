using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class RotatecamMenu : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(1 * Time.deltaTime, 2 * Time.deltaTime, 1 * Time.deltaTime);
    }
}
