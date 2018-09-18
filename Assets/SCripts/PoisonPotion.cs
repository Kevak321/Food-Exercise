using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonPotion : PotionItem
{
    public float damageTaken;

    public override void ApplyPotionEffect()
    {
        Debug.Log(string.Format("You took {0} damage", damageTaken));
    }
}
