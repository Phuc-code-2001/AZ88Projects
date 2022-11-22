using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Tower", menuName = "Scriptable/Tower")]
public class TowerProperties : ScriptableObject
{
    public const Int32 MaxLevel = 3;

    [SerializeField] private float[] attackPoint = new float[MaxLevel];
    [SerializeField] private float[] sellPrice = new float[MaxLevel];
    [SerializeField] private float[] upgradePrice = new float[MaxLevel - 1];
    [SerializeField] private float buyPrice;

    [SerializeField] private Sprite[] FrontSprites = new Sprite[MaxLevel];
    [SerializeField] private Sprite[] BackSprites = new Sprite[MaxLevel];

}
