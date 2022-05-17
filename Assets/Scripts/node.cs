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
    public GameObject _turret;

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
        if (!_buildManager.CanBuild)
        {
            return;
        }
        if (_turret != null)
        {
            Debug.Log("Cant build! - TODO: Display on screen");
            return;
        }

        _buildManager.BuildTurretOn(this);
    }

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
