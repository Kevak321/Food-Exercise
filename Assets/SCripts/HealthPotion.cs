using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : PotionItem
{
    public float healthRestored;

    public override void ApplyPotionEffect()
    {
        Debug.Log(string.Format("Restored: {0} health", healthRestored));
    }
}
