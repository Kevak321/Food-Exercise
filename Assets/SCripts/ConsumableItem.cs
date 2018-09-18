using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsumableItem : Item
{
    public int charges;
    public int maxCharges;

    public void Consume()
    {
        if (charges > 0)
        {
            charges--;
            ConsumeEffect();
        }
        else
        {
            Debug.Log(string.Format("Can't consume {0}, no charges left", displayName));
        }
    }

    public virtual void ConsumeEffect()
    {
        Debug.Log(string.Format("Consumed {0}, {1} of {2} charges remaning", displayName, charges, maxCharges));
    }
}
