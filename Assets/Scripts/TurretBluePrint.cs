using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Turret", menuName = "Turrets") ]
public class TurretBluePrint : ScriptableObject
{
    public GameObject prefab;
    public int cost;
}
