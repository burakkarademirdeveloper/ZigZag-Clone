using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Vector3 _ballDirection;
    public static event Action<Vector3> OnBallDirectionChanged;
    
    private void Start()
    {
        _ballDirection = Vector3.left;
    }

    private void Update()
    {
        HandleBallInput();
    }

    private void HandleBallInput()
    {
        if (Input.GetMouseButtonDown(0))
            ChangeBallDirection();
    }

    public void ChangeBallDirection()
    {
        if (_ballDirection.x == -1)
            _ballDirection = Vector3.forward;
        else
            _ballDirection = Vector3.left;
        OnBallDirectionChanged?.Invoke(_ballDirection);
    }
}
