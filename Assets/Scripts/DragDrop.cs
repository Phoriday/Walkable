using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour
{
    public bool drag;
    public void OnMouseDown()
    {
        drag= true;
    }
    public void OnMouseUp()
    {
        drag = false;
    }

    public void Update()
    {
        if (drag)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePos);
        }
    }
}
