using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Vector3 _ballDirecton;

    private void Start()
    {
        _ballDirecton = Vector3.left;
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

    private void ChangeBallDirection()
    {
        if (_ballDirecton.x == -1)
            _ballDirecton = Vector3.forward;
        else
            _ballDirecton = Vector3.left;
    }
}
