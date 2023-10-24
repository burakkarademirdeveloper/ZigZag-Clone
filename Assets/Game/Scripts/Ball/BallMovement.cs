using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 _ballDirection;

    private void OnEnable()
    {
        BallController.OnBallDirectionChanged += GetMoveDirection;
    }

    private void OnDisable()
    {
        BallController.OnBallDirectionChanged -= GetMoveDirection;
    }

    private void Update()
    {
        MoveBall();
    }
    
    private void MoveBall()
    {
        if (_ballDirection != null)
        {
            transform.Translate(_ballDirection * (_speed * Time.deltaTime));
        }
    }

    private void GetMoveDirection(Vector3 ballDirection)
    {
        _ballDirection = ballDirection;
    }
}
