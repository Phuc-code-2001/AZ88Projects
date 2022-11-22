using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Castle", menuName = "Scriptable/Castle")]
public class CastleProperties : ScriptableObject
{

    public float MaxHealthPoint { get; private set; }
    public float HealthPoint { get; private set; }
    public float DefensePoint { get; private set; }
    public const Int32 MaxLevel = 15;

    [SerializeField] private float maxHealthPointBase;
    [SerializeField] private float defensePointBase;
    [Range(1, CastleProperties.MaxLevel)]
    [SerializeField] private Int32 level = 1;

    [Header("Increase properties")]
    [SerializeField] private float healthPointOnLevel;
    [SerializeField] private float defensePointOnLevel;

    public CastleProperties() : base()
    {
        SetInfoByLevel();
        HealthPoint = MaxHealthPoint;
    }

    private void SetInfoByLevel()
    {
        MaxHealthPoint = maxHealthPointBase + healthPointOnLevel * (level - 1);
        DefensePoint = defensePointBase + defensePointOnLevel * (level - 1);
    }

    public bool Upgrade()
    {
        if(level < MaxLevel)
        {
            level++;
            SetInfoByLevel();
            HealthPoint = MaxHealthPoint;
            return true;
        }

        return false;
    }


}
