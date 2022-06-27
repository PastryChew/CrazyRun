using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
    private Vector2 _startPoint;
    private Vector2 _endPoint;
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                _startPoint.x = touch.position.x;
                _startPoint.y = touch.position.y;
                //Debug.Log("X: " + _startPoint.x + " Y: " + _startPoint.y);
            }
            if (touch.deltaPosition.x > 0)
            {
                if (touch.phase == TouchPhase.Ended)
                {
                    _endPoint.x = touch.position.x;
                    _endPoint.y = touch.position.y;
                    _endPoint -= _startPoint;
                    if (_endPoint.x > 100 && _endPoint.y <= 50)
                    {
                        //Debug.Log("Свайп вправо");
                    }
                    else
                    {
                      // Debug.Log("X2: " + _endPoint.x + " Y2: " + _endPoint.y);
                    }
                }
            }
        }
    }
}
