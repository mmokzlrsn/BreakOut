using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] float _forcePower = 10f;
    // Start is called before the first frame update
    void Start()
    {
        LaunchBall();
    }

    public void LaunchBall()
    {
        _rb.AddForce(Vector2.down * _forcePower, ForceMode2D.Impulse);
    }
     
}
