using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Mods
{
    public static List<Mod> mods;

    public class Mod
    {
        public string Name;
        public string Description;
        public string Path;
        public bool IsActive;
    }
}
