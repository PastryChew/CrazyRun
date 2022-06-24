using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomTouch : MonoBehaviour
{
    private float _tr;
    private Vector2 _touchpos1;
    private Vector2 _touchpos2;
    private void Update()
    {
        if (Input.touchCount > 1)
        {
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);
            _touchpos1 = new Vector2(touch1.position.x, touch1.position.y);
            _touchpos2 = new Vector2(touch2.position.x, touch2.position.y);
            if (touch1.phase == TouchPhase.Began && touch2.phase == TouchPhase.Began)
            {
                _tr = Vector2.Distance(_touchpos1, _touchpos2);
            }
            if (_tr < Vector2.Distance(_touchpos1, _touchpos2))
            {
                Debug.Log("Жест увеличение");
            }
            else if (_tr > Vector2.Distance(_touchpos2, _touchpos1)) Debug.Log("Жест уменьшения");
        }
    }
}
