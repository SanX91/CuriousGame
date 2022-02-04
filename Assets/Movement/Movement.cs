using UnityEngine;

public class Movement
{
    private Rigidbody _rigidbody;
    private float _moveSpeed;
    private float _rotateSpeed;

    public Movement(Rigidbody rigidbody)
    {
        _rigidbody = rigidbody;
    }

    public void SetMoveSpeed(float speed)
    {
        _moveSpeed = speed;
    }

    public void SetRotateSpeed(float speed)
    {
        _rotateSpeed = speed;
    }

    public void Move(float factor)
    {
        Vector3 direction = _rigidbody.transform.forward * factor * _moveSpeed * Time.fixedDeltaTime;
        _rigidbody.MovePosition(_rigidbody.position + direction);
    }

    public void Rotate(float factor)
    {
        Vector3 direction = _rigidbody.transform.up * factor * _rotateSpeed * Time.fixedDeltaTime;
        _rigidbody.MoveRotation(_rigidbody.rotation * Quaternion.Euler(direction));
    }
}
