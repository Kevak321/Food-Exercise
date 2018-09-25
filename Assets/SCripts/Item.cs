using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string displayName;
    public float value; //Price
    public float weight; //Kg

    public float GetPricePerWeight()
    {
        return value / weight;
    }

    public override string ToString()
    {
        return string.Format("This is a {0}, it costs {1} kr and weighs {2}kg. It's price per kilo is {3}.", displayName, value, weight, GetPricePerWeight());
    }

    public void OnMouseEnter()
    {
        print(ToString()); 
    }
} 
