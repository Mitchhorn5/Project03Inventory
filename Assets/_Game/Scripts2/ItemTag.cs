using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SlotTag { None, Hand }

[CreateAssetMenu(menuName = "Scriptable Objects/Item")]
public class ItemTag : ScriptableObject
{
    public Sprite sprite;
    public SlotTag itemTag;

    [Header("If the item can be equipped")]
    public GameObject equiptmentPrefab;
}
