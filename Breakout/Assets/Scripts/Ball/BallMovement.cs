using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] float _launchPower = 10f;
    // Start is called before the first frame update
    void Start()
    {
        LaunchBall();
    }

    public void LaunchBall()
    {
        // Randomly determine the direction (-1 for left, 1 for right)
        int randomDirection = Random.Range(0, 2) == 0 ? -1 : 1;

        // Calculate the launch angle within the specified range
        float launchAngle = 0; //Random.Range(0, 23f) * randomDirection;

        // Convert the launch angle to radians
        float launchAngleRad = launchAngle * Mathf.Deg2Rad;

        // Calculate the launch direction vector
        Vector2 launchDirection = new Vector2(Mathf.Sin(launchAngleRad), -Mathf.Cos(launchAngleRad));

        // Apply the launch force
        _rb.AddForce(launchDirection * _launchPower, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(Tags.PaddleTag))
        {
            // Calculate the angle of incidence
            float angle = Vector2.Angle(collision.contacts[0].normal, Vector2.up);

            // Check if the angle is within a certain threshold (e.g., 45 degrees)
            if (angle <= 45f)
            {
                // Apply force of the paddles velocity's %20 to the ball to avoid bouncing back vertically
                _rb.AddForce(new Vector2(collision.transform.GetComponent<Rigidbody2D>().velocity.x / 5f, 0f), ForceMode2D.Impulse);
            }
        }
    }

}
