﻿/*
 * Armor -
 * Created by : Allan N. Murillo
 * Last Edited : 3/2/2020
 */

using UnityEngine;
using ANM.Scriptables.Inventory;

namespace ANM.Inventory
{
    [CreateAssetMenu(menuName = "Scriptables/Inventory/Armor")]
    public class Armor : Item
    {
        public ArmorType armorType;
        public Mesh armorMesh;
        public Material[] materials;
        public bool baseBodyEnabled;

        public Armor()
        {
            type = ItemType.ARMOR;
        }
    }
}

public enum ArmorType
{
    CHEST, LEGS, ARMS, HEAD
}
