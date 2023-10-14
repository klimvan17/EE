using System.Collections.Generic;
using System.Collections;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]

public class UnitMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 6;
    [SerializeField] private float _jumpForce = 7;
    private Rigidbody2D _body;
    [SerializeField] private GroundCheck _ground;

    public float MoveInput { get; set; }
    public bool OnGround => _ground.OnGround;

    private void Start()
    {
        _body = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _body.velocity = new Vector2(_moveSpeed * MoveInput, _body.velocity.y);
    }

    public void TryJump()
    {
        if (_ground.OnGround)
            _body.velocity = new Vector2(0, _jumpForce);
    }
}
