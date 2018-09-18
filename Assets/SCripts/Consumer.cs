using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumer : MonoBehaviour
{
    public ConsumableItem[] item;

    public int selectedIndex;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            item[selectedIndex].Consume();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && selectedIndex != 0)
        {
            selectedIndex--;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && selectedIndex < item.Length - 1)
        {
            if (selectedIndex < item.Length - 1)
                selectedIndex++;
            else
                selectedIndex = 0;
        }
    }
}
