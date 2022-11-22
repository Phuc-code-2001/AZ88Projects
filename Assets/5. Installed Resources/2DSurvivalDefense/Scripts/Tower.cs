using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tower : MonoBehaviour
{
    [SerializeField] TowerProperties BaseProperties;
    
    [Range(1, TowerProperties.MaxLevel)]
    [SerializeField] Int32 level = 1;  

    public bool Upgrade()
    {
        if (level < TowerProperties.MaxLevel)
        {
            level++;
            return true;
        }

        return false;
    }

    private void OnMouseDown()
    {
        Debug.Log(name + " was clicked!");
        // Handle Click To Do Action (Sell, Upgrade)
    }


}
