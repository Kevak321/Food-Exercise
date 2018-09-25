using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usable : Item
{
    public int Uses;
    public int maxUses;

    public void OnMouseUpAsButton()
    {
        Use();
    }

    public virtual string NoUsesRemainingText()
    {
        return (string.Format("Can't use the {0}, no uses left", displayName));
    }

    public virtual void Use()
    {
        if (Uses > 0)
        {
            Uses--;
            Debug.Log(UseText());
        }
        else
        {
            Debug.Log(NoUsesRemainingText());
        }
    }


    public virtual string UseText()
    {
        return string.Format("Used the {0}, {1} of {2} use(s) remaining", displayName, Uses, maxUses);
    }
}
