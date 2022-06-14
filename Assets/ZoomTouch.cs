using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomTouch : MonoBehaviour
{
    private float tr;
    private Vector2 touchpos1;
    private Vector2 touchpos2;
    private void Update()
    {
        if (Input.touchCount > 1)
        {
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);
            touchpos1 = new Vector2(touch1.position.x, touch1.position.y);
            touchpos2 = new Vector2(touch2.position.x, touch2.position.y);
            if (touch1.phase == TouchPhase.Began && touch2.phase == TouchPhase.Began)
            {
                tr = Vector2.Distance(touchpos1, touchpos2);
            }
            if (tr < Vector2.Distance(touchpos1, touchpos2))
            {
                Debug.Log("Жест увеличение");
            }
            else if (tr > Vector2.Distance(touchpos2, touchpos1)) Debug.Log("Жест уменьшения");
        }
    }
}
