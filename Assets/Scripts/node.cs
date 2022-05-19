using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class node : MonoBehaviour
{
    [SerializeField] private Color hoverColor;
    private Renderer _rend;
    private Color _startColor;
    [HideInInspector]
    public GameObject _turret;

    [HideInInspector] public TurretBluePrint turretBluePrint;
    [HideInInspector] public bool isUpgraded = false;

    private BuildManager _buildManager;
    void Start()
    {
        _rend = GetComponent<Renderer>();
        _startColor = _rend.material.color;
        _buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position;
    }

    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
       
        if (_turret != null)
        {
            _buildManager.SelectNode(this);
            return;
        }
        if (!_buildManager.CanBuild)
        {
            return;
        }

       BuildTurret(_buildManager.GetTurretToBuild());
    }

    void BuildTurret(TurretBluePrint bluePrint)
    {
        if (PlayerStats.Money < bluePrint.cost)
        {
            
            return;
        }

        PlayerStats.Money -= bluePrint.cost;
        GameObject turret = (GameObject)Instantiate(bluePrint.prefab,  GetBuildPosition(), Quaternion.identity);
        _turret = turret;
        
    }

    //  public void UpgradeTurret()
    //{
      //  if (PlayerStats.Money < bluePrint.upgradecost)
     //   {
            
          //  return;
      //  }

      //  PlayerStats.Money -= bluePrint.upgradecost;
      //  GameObject turret = (GameObject)Instantiate(bluePrint.upgradedprefab,  GetBuildPosition(), Quaternion.identity);
       // _turret = turret;
  //  }
    private void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
        if (!_buildManager.CanBuild)
        {
            return;
        }
        _rend.material.color = hoverColor;
        
    }

    private void OnMouseExit()
    {
        _rend.material.color = _startColor;
    }
}
