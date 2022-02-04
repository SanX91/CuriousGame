using UnityEngine;

public class Character : MonoBehaviour
{
    public float _moveSpeed = 10;
    public float _rotateSpeed = 100;
    private Movement _movement;

    private void Start()
    {
        _movement = new Movement(GetComponent<Rigidbody>());
        _movement.SetMoveSpeed(_moveSpeed);
        _movement.SetRotateSpeed(_rotateSpeed);
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        _movement.Rotate(horizontal);
        _movement.Move(vertical);
    }
}