using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionItem : ConsumableItem
{
    public float duration;

    public override void ConsumeEffect()
    {
        base.ConsumeEffect();
        ApplyPotionEffect();
    }

    public virtual void ApplyPotionEffect()
    {
    }
}
