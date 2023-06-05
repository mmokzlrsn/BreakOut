using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PaddleMovemenet : MonoBehaviour
{
    float _speed = 12;
    float _moveDirection;
    [SerializeField] Rigidbody2D _rb;  
    private float xMin = -4f, xMax = 4f;
 
     

    void Update()
    {
        ReadMoveDirection();
    }

    void ReadMoveDirection()
    {
        _moveDirection = Input.GetAxis(Constants.Horizontal);

    }

    private void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        _rb.velocity = new Vector2(_moveDirection, 0) * _speed;
         
        //transform.position = new Vector2( Mathf.Clamp(transform.position.x, xMin, xMax) , transform.position.y);
    }
}
