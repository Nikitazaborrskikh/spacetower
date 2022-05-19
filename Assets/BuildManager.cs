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
    private node selectednode;
    public NodeUi nodeUi;
   

    public bool CanBuild
    {
        get { return _turretToBuild != null; }
    }

    

    public void SelectNode(node node)
    {
        if (selectednode == node)
        {
            DeselectNode();
            return;
        }
        selectednode = node;
        _turretToBuild = null;

        nodeUi.SetTarget(node);
    }
    public void SelectTurretToBuild(TurretBluePrint turret)
    {
        _turretToBuild = turret;
        selectednode = null;
        nodeUi.Hide();
    }

    public void DeselectNode()
    {
        selectednode = null;
        nodeUi.Hide();
    }

    public TurretBluePrint GetTurretToBuild()
    {
        return _turretToBuild;
    }
}
