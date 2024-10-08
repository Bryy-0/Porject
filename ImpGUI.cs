using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpGUI : MonoBehaviour
{
    public Texture2D buttonImage;
    public Vector2 position;
    public Vector2 size;


    private void OnGUI()
    {
        GUI.Box(new Rect (0, 0, 1469, 728), "Exercise");

        if (GUI.Button(new Rect(10, 20, 40, 40), "Up"))
        {
            print("Moved up by 1");
            position.y -= 10;

        }
        if (GUI.Button(new Rect(1419, 20, 40, 40), "down"))
        {
            print("Moved down by 1");
            position.y += 10;
        }
        if (GUI.Button(new Rect(10, 678, 40, 40), "left"))
        {
            print("Moved to left by 1");
            position.x -= 10;
        }
        if (GUI.Button(new Rect(1419, 678, 40, 40), "right"))
        {
            print("Moved to the right by 1");
            position.x += 10;
        }

        GUI.Box(new Rect(position, size), buttonImage);
        

    }
}