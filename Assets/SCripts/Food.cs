using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : Usable
{
    public float saturation;
    public bool isYummy = false;

    public override void Use()
    {

    }
    public override string UseText()
    {
        return base.UseText();
    }
    public override string ToString()
    {
        return base.ToString();
    }
    public string YummyToString()
    {
        return ToString();
    }
}
