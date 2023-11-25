using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Reflection;

[System.Serializable]
public static class Inventory
{
    public static int InventorySlots;
    public static int StackSize;
    public static float MaxWeight;
    public static float MaxVolume;
    public static float Weight;
    public static float Volume;
    public static bool UseWeight;
    public static bool UseVolume;
    public static bool UseSlots;

    public static List<InventoryObject> Objects;
    public static List<Object> PossibleObjects = new List<Object>
    {

    };
    public class InventoryObject
    {
        public int NumberOfObjects;
        public object ObjectInStack;
    }
    public class Object
    {
        public string ObjectName;
        public string[] EffectTypes;
        public string[] EffectNames;
        public string[] EffectValues;
        public string[] Components;
        public int Volume;
        public int Weight;
        public int MaxDurability;
        public int Durability;
    }
    public static int GetItemIndex(string Name)
    {
        for(int i = 0; i < Objects.Count; i++)
        {
            if(Objects[i].ObjectInStack.ObjectName == Name)
            {
                return i;
            }
        }
        Debug.LogError($"{Name} does not extist");
        return -1;
    }

    public static bool ContainsItem(string Name)
    {
        for(int t = 0; t < Objects.Count; t++)
        {
            if(Objects[t].ObjectInStack.ObjectName == Name)
            {
                return true;
            }
        }
        return false;
    }

    public int NumberOfItems(string Name)
    {
        int Output = 0;
        for(int t = 0; t < Objects.Count; t++)
        {
            if(Objects[t].ObjectInStack.ObjectName == Name)
            {
                Output += Objects[t].NumberOfObjects;
            }
        }
        return Output;
    }
}

