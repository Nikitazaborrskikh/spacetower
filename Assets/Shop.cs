using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Shop : MonoBehaviour
{
    private BuildManager _buildManager;
    public TurretBluePrint[] turretBluePrint;

    void Start()
    {
        _buildManager = BuildManager.instance;
    }
    public void SelectStandartTurret()
    {
        Debug.Log("biba");
        _buildManager.SelectTurretToBuild(turretBluePrint[0]);
    }
    public void SelectIceTower()
    {
        Debug.Log("boba");
        _buildManager.SelectTurretToBuild(turretBluePrint[1]);
    }

    public void SecectTeslaTower()
    {
        Debug.Log("boba and biba");
        _buildManager.SelectTurretToBuild(turretBluePrint[2]);
    }
    
}
