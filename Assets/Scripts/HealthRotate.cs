using UnityEngine;

public class HealthRotate : MonoBehaviour
{
    float XLock = 60;
    float lockPos = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(XLock, lockPos, lockPos);
    }
}
