using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private void Awake()
    {
        instance = this;
    }

    private TurretBluePrint _turretToBuild;
    public GameObject standartTurretPrefab;
    public GameObject AnotherTurretPrefab;
   

    public bool CanBuild
    {
        get { return _turretToBuild != null; }
    }

    public void BuildTurretOn(node node)
    {
        if (PlayerStats.Money < _turretToBuild.cost)
        {
            Debug.Log("Not enough Money");
            return;
        }

        PlayerStats.Money -= _turretToBuild.cost;
      GameObject turret = (GameObject)Instantiate(_turretToBuild.prefab,  node.GetBuildPosition(), Quaternion.identity);
      node._turret = turret;
      Debug.Log("Money left" + PlayerStats.Money);
    }

    public void SelectTurretToBuild(TurretBluePrint turret)
    {
        _turretToBuild = turret;
    }
}
