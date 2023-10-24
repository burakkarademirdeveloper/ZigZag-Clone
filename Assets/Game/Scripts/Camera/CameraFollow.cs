using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _ballTransform;
    private Vector3 _newPosition;
    private Vector3 _offset;
    [SerializeField] private float _smoothSpeed;
    
    private void Start()
    {
        _offset = transform.position - _ballTransform.position;
    }

    private void LateUpdate()
    {
        FollowBall();
    }


    private void FollowBall()
    {
        _newPosition = _ballTransform.position + _offset;
        transform.position = Vector3.Lerp(transform.position, _newPosition, _smoothSpeed * Time.deltaTime);
    }
}
