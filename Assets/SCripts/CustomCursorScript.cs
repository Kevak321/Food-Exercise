using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCursorScript : MonoBehaviour
{

    public Texture2D cursorTexture;
    // Use this for initialization
    void Start()
    {
        if (cursorTexture != null)
        {
            SetCustomCursor();
        }
    }

    void SetCustomCursor()
    {
        Cursor.SetCursor(this.cursorTexture, Vector2.zero, CursorMode.Auto);
    }
}
