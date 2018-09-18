using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string displayName;
    public float value; //gold
    public float weight; //kg

    public float GetGoldPerWeight()
    {
        return value / weight;
    }
}
