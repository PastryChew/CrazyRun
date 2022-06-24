using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementHandler : MonoBehaviour
{
    public InputHandler inputHandler;
    [SerializeField] private float _ballSpeed = 1f;

    private void Start()
    {
        
    }

    private void Update()
    {
        MoveBall();
    }

    private void MoveBall()
    {
        if (inputHandler.IsTouchOnScreen())
        {
           Vector2 currDeltaPos = inputHandler.GetTouchDeltaPosition();
            currDeltaPos *= _ballSpeed;
            Vector3 newGravityVector = new Vector3(currDeltaPos.x, Physics.gravity.y, currDeltaPos.y);
            Physics.gravity = newGravityVector;
        }
    }
}
